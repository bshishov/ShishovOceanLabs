using System;
using System.Drawing;
using System.Windows.Forms;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.DomainObject.PillarGrid;
using Slb.Ocean.Petrel.DomainObject.Well;
using Slb.Ocean.Petrel.UI;
using Slb.Ocean.Petrel.Workflow;
using Slb.Ocean.Core;
using System.Diagnostics;

namespace ShishovLab1
{
    /// <summary>
    /// This class is the user interface which forms the focus for the capabilities offered by the process.  
    /// This often includes UI to set up arguments and interactively run a batch part expressed as a workstep.
    /// </summary>
    public partial class WorkstepUI : UserControl
    {
        private ShishovLab2Workstep _workstep;
        /// <summary>
        /// The argument package instance being edited by the UI.
        /// </summary>
        private ShishovLab2Workstep.Arguments _args;
        /// <summary>
        /// Contains the actual underlaying context.
        /// </summary>
        private WorkflowContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstepUI"/> class.
        /// </summary>
        /// <param name="workstep">the workstep instance</param>
        /// <param name="args">the arguments</param>
        /// <param name="context">the underlying context in which this UI is being used</param>
        public WorkstepUI(ShishovLab2Workstep workstep, ShishovLab2Workstep.Arguments args, WorkflowContext context)
        {
            InitializeComponent();

            _workstep = workstep;
            _args = args;
            _context = context;
        }

#if DEBUG
        public WorkstepUI()
        {
            InitializeComponent();
            _workstep = null;
            _args = null;
            _context = null;
            Debug.WriteLine("[Debug]: dialog created");
        }
#endif

        private void WorkstepUI_Load(object sender, EventArgs e)
        {
            if (_workstep != null && _args != null)
            {
                NameLabel.Text = _workstep.Description.ShortDescription;
                DescriptionLabel.Text = _workstep.Description.Description;
                UpdateUI();
            }
        }

        private void ValueDropTarget_DragDrop(object sender, DragEventArgs e)
        {
            var grid = e.Data.GetData(typeof(Grid)) as Grid;
            if (grid == null)
            {
                PetrelLogger.ErrorBox("Объект не является 3D-сеткой!");
                return;
            }
            _args.ShishovGrid = grid;
            UpdateUI();
        }

        /// <summary>
        /// Runs Executor
        /// </summary>
        private void Run()
        {
            if (_context is WorkstepProcessWrapper.Context)
            {
                if (_args.ShishovGrid != null && _args.ShishovGrid != null)
                {
                    var ex = _workstep.GetExecutor(_args,
                        new WorkstepProcessWrapper.RuntimeContext());
                    ex.ExecuteSimple();
                }
                else
                {
                    PetrelLogger.ErrorBox("Не всем входным аргументам заданы зачения!");
                }
            }

            _context.OnArgumentPackageChanged(this,
                new WorkflowContext.ArgumentPackageChangedEventArgs());
        }
        
        
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Run();
            UpdateUI();
        }

        /// <summary>
        /// Shows result property in 3d viewer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowButton_Click(object sender, EventArgs e)
        {
            var win = PetrelProject.ToggleWindows.Add(WellKnownWindows.Window3D);
            win.ShowObject(_args.ShishovWellLog.Borehole);
            win.ShowObject(_args.ShishovResultProperty);
        }

        /// <summary>
        /// Apply And close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Run();
            if (ParentForm != null) ParentForm.Close();
        }

        private void UpdateUI()
        {
            NumCellsValue.Text = _args.ShishovNumCells.ToString();

            if (_args.ShishovResultProperty != null)
            {
                var imgSvc = CoreSystem.GetService<IImageInfoFactory>(_args.ShishovResultProperty);
                CreatedPropertyValue.Text = _args.ShishovResultProperty != null ? _args.ShishovResultProperty.Name : "";
                CreatedPropertyValue.Image = imgSvc.GetImageInfo(_args.ShishovResultProperty).TypeImage;
                ShowButton.Enabled = true;
            }
            else
            {
                CreatedPropertyValue.Text = "";
                ShowButton.Enabled = false;
                CreatedPropertyValue.Image = null;
            }

            if (_args.ShishovGrid != null)
            {
                var b = _args.ShishovGrid.BoundingBox;
                var volume = b.Width * b.Height * b.Length / (_args.ShishovGrid.NumCellsIJK.I * _args.ShishovGrid.NumCellsIJK.J * _args.ShishovGrid.NumCellsIJK.K);

                var imgSvc = CoreSystem.GetService<IImageInfoFactory>(_args.ShishovGrid);
                GridValue.Text = _args.ShishovGrid != null ? String.Format("{0} ({1})", _args.ShishovGrid.Name, volume) : "";
                GridValue.Image = imgSvc.GetImageInfo(_args.ShishovGrid).TypeImage;
            }
            else
            {
                GridValue.Text = "";
                GridValue.Image = null;
            }


            if (_args.ShishovWellLog != null)
            {
                var imgSvc = CoreSystem.GetService<IImageInfoFactory>(_args.ShishovWellLog);
                WellLogValue.Text = String.Format("{0} ({1})", _args.ShishovWellLog.Name, _args.ShishovWellLog.Borehole.Name);
                WellLogValue.Image = imgSvc.GetImageInfo(_args.ShishovWellLog).TypeImage;
            }
            else
            {
                WellLogValue.Text = "";
                WellLogValue.Image = null;
            }
        }

        private void WellLog_DragDrop(object sender, DragEventArgs e)
        {
            var wellLog = e.Data.GetData(typeof(WellLog)) as WellLog;
            if (wellLog == null)
            {
                PetrelLogger.ErrorBox("Объект не является каротажной кривой!");
                return;
            }
            _args.ShishovWellLog = wellLog;
            UpdateUI();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (ParentForm != null) ParentForm.Close();
        }
    }
}

