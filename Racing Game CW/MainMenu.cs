using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    public partial class MainMenu : Form
    {
        private readonly SaveManager _saveManager = new SaveManager();

        public MainMenu()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(pnl_top);
            MenuUI.SecondaryPanel(pnl_sideBar);
            MenuUI.BodyButton(btn_newSave);
            MenuUI.Button(btn_loadSave);
            MenuUI.Button(btn_settings);
            MenuUI.ComboBox(cbx_loadSave);
            MenuUI.HeadingLabel(lbl_newSave);

            //cbx_loadSave.Items = _saveManager.LoadSaveList();
        }

        //For creating a new save:
        private void btn_newSave_Click(object sender, EventArgs e)
        {
            //Validate the save name first (could do all these processes in saveManager)
            
            //Make sure there is a folder to save files in:
            _saveManager.SaveLocationAvailable(true);

            string saveName = tbx_saveName.Text;
        }

        //For loading a current save:
        private void btn_loadSave_Click(object sender, EventArgs e)
        {
            _saveManager.SaveLocationAvailable(false);
            
            int saveValue = cbx_loadSave.SelectedIndex; //Could change to .selectedItem, if using a "save" object
        }
    }
}