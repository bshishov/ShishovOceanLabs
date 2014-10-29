using System;
using System.Windows.Forms;
using Slb.Ocean.Petrel;
using Slb.Ocean.Petrel.UI;
using Slb.Ocean.Petrel.UI.Tools;

namespace ShishovLab1
{
    /// <summary>
    /// This class contains registration methods and Click eventhandlers for the
    /// Petrel Menu extension.
    /// </summary>
    public static class MenuExtension
    {
        public static void InitMenu()
        {
            var item = new PetrelMenuItem("Shishov plugin");
            var RunLab11 = new PetrelButtonTool("Run Lab 1", MenuExtension.RunLab11_ToolClick);
            item.AddTool(RunLab11);

            PetrelSystem.ToolService.AddTopLevelMenu(item);
        }

        #region Toolbutton click eventhandlers

        private static void RunLab11_ToolClick(object sender, EventArgs args)
        {            
            MessageBox.Show("LOL","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }

}