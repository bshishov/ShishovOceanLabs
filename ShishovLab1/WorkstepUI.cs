using System;
using System.Drawing;
using System.Windows.Forms;

using Slb.Ocean.Petrel.Workflow;
using Slb.Ocean.Core;

namespace ShishovLab1
{
    /// <summary>
    /// This class is the user interface which forms the focus for the capabilities offered by the process.  
    /// This often includes UI to set up arguments and interactively run a batch part expressed as a workstep.
    /// </summary>
    partial class WorkstepUI : UserControl
    {
        private ShishovLab2Workstep workstep;
        /// <summary>
        /// The argument package instance being edited by the UI.
        /// </summary>
        private ShishovLab2Workstep.Arguments args;
        /// <summary>
        /// Contains the actual underlaying context.
        /// </summary>
        private WorkflowContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstepUI"/> class.
        /// </summary>
        /// <param name="workstep">the workstep instance</param>
        /// <param name="args">the arguments</param>
        /// <param name="context">the underlying context in which this UI is being used</param>
        public WorkstepUI(ShishovLab2Workstep workstep, ShishovLab2Workstep.Arguments args, WorkflowContext context)
        {
            InitializeComponent();

            this.workstep = workstep;
            this.args = args;
            this.context = context;
        }

        private void WorkstepUI_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = args.ShishovGrid != null ? args.ShishovGrid.Name : "None grid specified";
    }
}
