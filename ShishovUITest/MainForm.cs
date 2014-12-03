using System;
using System.Windows.Forms;
using ShishovLab1;

namespace ShishovUITest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var control = new ShishovLab2Workstep.UIFactory().CreateDebugUI();
            //control.Dock = DockStyle.Fill;
            //this.Controls.Add(control);
        }
    }
}
