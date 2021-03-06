using System;

using Slb.Ocean.Core;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.UI;
using Slb.Ocean.Petrel.Workflow;
using Slb.Ocean.Petrel.DomainObject.Well;
using Slb.Ocean.Petrel.DomainObject.PillarGrid;
using Slb.Ocean.Geometry;
using System.Collections.Generic;
using Slb.Ocean.Petrel.DomainObject;
using Slb.Ocean.Basics;

namespace ShishovLab1
{
    /// <summary>
    /// This class contains all the methods and subclasses of the MainWorkstep.
    /// Worksteps are displayed in the workflow editor.
    /// </summary>
    public class ShishovLab2Workstep : Workstep<ShishovLab2Workstep.Arguments>, IExecutorSource, IAppearance, IDescriptionSource
    {
        #region Overridden Workstep methods

        /// <summary>
        /// Creates an empty Argument instance
        /// </summary>
        /// <returns>New Argument instance.</returns>
        protected override ShishovLab2Workstep.Arguments CreateArgumentPackageCore(IDataSourceManager dataSourceManager)
        {
            return new Arguments(dataSourceManager);
        }
        /// <summary>
        /// Copies the Arguments instance.
        /// </summary>
        /// <param name="fromArgumentPackage">the source Arguments instance</param>
        /// <param name="toArgumentPackage">the target Arguments instance</param>
        protected override void CopyArgumentPackageCore(Arguments fromArgumentPackage, Arguments toArgumentPackage)
        {
            DescribedArgumentsHelper.Copy(fromArgumentPackage, toArgumentPackage);
        }

        /// <summary>
        /// Gets the unique identifier for this Workstep.
        /// </summary>
        protected override string UniqueIdCore
        {
            get
            {
                return "8379c3e3-a9c2-4a06-a365-bc31fe93cd9d";
            }
        }        
        #endregion

        #region IExecutorSource Members and Executor class

        /// <summary>
        /// Creates the Executor instance for this workstep. This class will do the work of the Workstep.
        /// </summary>
        /// <param name="argumentPackage">the argumentpackage to pass to the Executor</param>
        /// <param name="workflowRuntimeContext">the context to pass to the Executor</param>
        /// <returns>The Executor instance.</returns>
        public Slb.Ocean.Petrel.Workflow.Executor GetExecutor(object argumentPackage, WorkflowRuntimeContext workflowRuntimeContext)
        {
            return new Executor(argumentPackage as Arguments, workflowRuntimeContext);
        }

        public class Executor : Slb.Ocean.Petrel.Workflow.Executor
        {
            readonly Arguments _arguments;
            WorkflowRuntimeContext _context;

            public Executor(Arguments arguments, WorkflowRuntimeContext context)
            {
                _arguments = arguments;
                _context = context;
            }

            private const string PropFormat = "{0} ({1}) upscaled";
            private const string LogFormat = "{0} [{1}] = {2}";

            public override void ExecuteSimple()
            {
                int count = 0;
                var grid = _arguments.ShishovGrid;
                var wellLog = _arguments.ShishovWellLog;

                // все действия по изменению данных строго внутри транзакции
                using (var trans = DataManager.NewTransaction()) 
                {
                    // запрашиваем исключительный доступ к свойствам сетки
                    trans.Lock(grid.PropertyCollection); 
                    
                    // создаем новое свойство и задаем его имя                    
                    Property prop = grid.PropertyCollection.CreateProperty(wellLog.WellLogVersion.Template);
                    prop.Name = string.Format(PropFormat, wellLog.Name, wellLog.Borehole.Description.Name);
                    
                    // получаем перечислитель замеров каротажки в явном виде
                    var enumSamples = wellLog.Samples.GetEnumerator();                    
                    
                    // получаем доступ к штатному сервису Petrel:
                    var pgIntersection = CoreSystem.GetService<IPillarGridIntersectionService>();

                    // получаем траекторию скважины в виде линии и запрашиваем список пересечений этой линии с ячейками сетки
                    var polyline = (IPolyline3)wellLog.Borehole.Trajectory.Polyline;
                    var intersectionsegments = pgIntersection.GetPillarGridPolylineIntersections(grid, polyline);
                    
                    // проходим в цикле по найденным точкам пересечения
                    SegmentCellIntersection enteringSegment = new SegmentCellIntersection();
                    SegmentCellIntersection leavingSegment;
                    var enteringMD = double.NaN;
                    var leavingMD = double.NaN;
                    bool FirstTime = true;
                    foreach (SegmentCellIntersection segment in intersectionsegments)
                    {
                        // на первой итерации нужно только инициализировать внутренние переменные
                        if (FirstTime)
                        {
                            FirstTime = false;
                            enteringSegment = segment;
                            enteringMD = wellLog.Borehole.Transform(grid.Domain, 
                            segment.IntersectionPoint.Z, Domain.MD);
                        
                            // проматываем цикл по замерам, пока не дойдем до нужной глубины
                            while (enumSamples.MoveNext())
                            {
                                if (enumSamples.Current.MD >= enteringMD)
                                    break;
                            }
                            continue;
                        } leavingSegment = segment;
                        
                        // находим измеренные глубины точек пересечения вдоль ствола скважины
                        enteringMD = wellLog.Borehole.Transform(grid.Domain, enteringSegment.IntersectionPoint.Z, Domain.MD);
                        leavingMD = wellLog.Borehole.Transform(grid.Domain, leavingSegment.IntersectionPoint.Z, Domain.MD);
                    
                        // находим индекс ячейки                    
                        var cellIndex = enteringSegment.EnteringCell;
                        var avg = float.NaN;
                        // если текущее значение глубины замера внутри текущей ячейки
                        if (enumSamples.Current.MD <= leavingMD)
                        {
                            var numSamples = 1;
                            var total = enumSamples.Current.Value;
                            
                            // вручную проматываем замеры каротажной кривой в этой ячейке
                            while (enumSamples.MoveNext())
                            {
                                if (enumSamples.Current.MD <= leavingMD)
                                {
                                    numSamples++;
                                    total += enumSamples.Current.Value;
                                }
                                else
                                    break;
                            }
                            
                            // теперь вычисляем усредненное значение свойства
                            avg = (float)(total / numSamples);
                            PetrelLogger.InfoOutputWindow(string.Format(LogFormat, prop.Name, cellIndex.ToString(), avg));
                        }
                        
                        // и записываем его в новое свойство сетки
                        prop[cellIndex] = avg;
                        count++;
                        enteringSegment = leavingSegment;
                    }

                    _arguments.ShishovNumCells = count;
                    _arguments.ShishovResultProperty = prop;
                    // если проблем нет, следующая строчка создаст наше свойство
                    trans.Commit();                    
                }
            }
        }

        #endregion

        /// <summary>
        /// ArgumentPackage class for MainWorkstep.
        /// Each public property is an argument in the package.  The name, type and
        /// input/output role are taken from the property and modified by any
        /// attributes applied.
        /// </summary>
        public class Arguments : DescribedArgumentsByReflection
        {
            public Arguments()
                : this(DataManager.DataSourceManager)
            {
                // Setting defaults
                ShishovWellLog = WellLog.NullObject;
                ShishovGrid = Grid.NullObject;
            }

            public Arguments(IDataSourceManager dataSourceManager)
            {
            }

            private Slb.Ocean.Petrel.DomainObject.Well.WellLog _shishovWellLog;
            private Slb.Ocean.Petrel.DomainObject.PillarGrid.Grid _shishovGrid;
            private int _shishovNumCells;
            private Slb.Ocean.Petrel.DomainObject.PillarGrid.Property _shishovResultProperty;

            [Description("Well Log", "Каротажная кривая")]
            public Slb.Ocean.Petrel.DomainObject.Well.WellLog ShishovWellLog
            {
                internal get { return this._shishovWellLog; }
                set { this._shishovWellLog = value; }
            }

            [Description("Grid", "3D-сетка из модели")]
            public Slb.Ocean.Petrel.DomainObject.PillarGrid.Grid ShishovGrid
            {
                internal get { return this._shishovGrid; }
                set { this._shishovGrid = value; }
            }

            [Description("Num Cells", "Количество ячеек")]
            public int ShishovNumCells
            {
                get { return this._shishovNumCells; }
                internal set { this._shishovNumCells = value; }
            }

            [Description("Property", "Результирующее свойство сетки")]
            public Slb.Ocean.Petrel.DomainObject.PillarGrid.Property ShishovResultProperty
            {
                get { return this._shishovResultProperty; }
                internal set { this._shishovResultProperty = value; }
            }


        }
    
        #region IAppearance Members
        public event EventHandler<TextChangedEventArgs> TextChanged;
        protected void RaiseTextChanged()
        {
            if (this.TextChanged != null)
                this.TextChanged(this, new TextChangedEventArgs(this));
        }

        public string Text
        {
            get { return Description.Name; }
            private set 
            {
                // TODO: implement set
                this.RaiseTextChanged();
            }
        }

        public event EventHandler<ImageChangedEventArgs> ImageChanged;
        protected void RaiseImageChanged()
        {
            if (this.ImageChanged != null)
                this.ImageChanged(this, new ImageChangedEventArgs(this));
        }

        public System.Drawing.Bitmap Image
        {
            get { return PetrelImages.Modules; }
            private set 
            {
                // TODO: implement set
                this.RaiseImageChanged();                
            }
        }
        #endregion

        #region IDescriptionSource Members

        /// <summary>
        /// Gets the description of the MainWorkstep
        /// </summary>
        public IDescription Description
        {
            get { return MainWorkstepDescription.Instance; }
        }

        /// <summary>
        /// This singleton class contains the description of the MainWorkstep.
        /// Contains Name, Shorter description and detailed description.
        /// </summary>
        public class MainWorkstepDescription : IDescription
        {
            /// <summary>
            /// Contains the singleton instance.
            /// </summary>
            private  static MainWorkstepDescription instance = new MainWorkstepDescription();
            /// <summary>
            /// Gets the singleton instance of this Description class
            /// </summary>
            public static MainWorkstepDescription Instance
            {
                get { return instance; }
            }

            #region IDescription Members

            /// <summary>
            /// Gets the name of MainWorkstep
            /// </summary>
            public string Name
            {
                get { return "Lab2 workstep (Shishov)"; }
            }
            /// <summary>
            /// Gets the short description of MainWorkstep
            /// </summary>
            public string ShortDescription
            {
                get { return "Алгоритм расчёта средних значений каротажной кривой в ячейказ 3D-сетки"; }
            }
            /// <summary>
            /// Gets the detailed description of MainWorkstep
            /// </summary>
            public string Description
            {
                get { return "Лабораторная работа №2. Автор Шишов Борис (AC-10-04)"; }
            }

            #endregion
        }
        #endregion        

        public class UIFactory : WorkflowEditorUIFactory
        {
            /// <summary>
            /// This method creates the dialog UI for the given workstep, arguments
            /// and context.
            /// </summary>
            /// <param name="workstep">the workstep instance</param>
            /// <param name="argumentPackage">the arguments to pass to the UI</param>
            /// <param name="context">the underlying context in which the UI is being used</param>
            /// <returns>a Windows.Forms.Control to edit the argument package with</returns>
            protected override System.Windows.Forms.Control CreateDialogUICore(Workstep workstep, object argumentPackage, WorkflowContext context)
            {
                return new WorkstepUI((ShishovLab2Workstep)workstep, (Arguments)argumentPackage, context);
            }
        }
    }
}