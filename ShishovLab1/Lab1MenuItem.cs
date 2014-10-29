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
    public static class Lab1MenuItem
    {
        public static void AddNewMenuItemsUnderLabs1()
        {
            PetrelMenuItem Labs1 = new PetrelMenuItem("Labs");
            PetrelButtonTool RunLab11 = new PetrelButtonTool("Run Lab 1", Lab1MenuItem.RunLab11_ToolClick);
            Labs1.AddTool(RunLab11);

            PetrelSystem.ToolService.AddTopLevelMenu(Labs1);
        }

        #region Toolbutton click eventhandlers

        private static void RunLab11_ToolClick(object sender, EventArgs args)
        {            
            MessageBox.Show("LOL","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }

}