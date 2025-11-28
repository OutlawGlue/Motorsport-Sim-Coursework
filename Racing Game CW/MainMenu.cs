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
            MenuUI.Panel(Pnl_top);
            MenuUI.SecondaryPanel(Pnl_sideBar);
            MenuUI.BodyButton(Btn_newSave);
            MenuUI.Button(Btn_loadSave);
            MenuUI.Button(Btn_settings);
            MenuUI.ComboBox(Cbx_loadSave);
            MenuUI.HeadingLabel(Lbl_newSave);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Cbx_loadSave.Items.Clear();
            string[] files = _saveManager.LoadSaveList();
            foreach (string file in files)
            {
                Cbx_loadSave.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        //For creating a new save:
        private void Btn_newSave_Click(object sender, EventArgs e)
        {
            //Validate the save name first (could do all these processes in saveManager)

            //Make sure there is a folder to save files in:
            _saveManager.SaveLocationAvailable(true);

            bool created;
            do
            {
                string saveName = tbx_saveName.Text;
                created = _saveManager.CreateNewSave(saveName);
                tbx_saveName.Clear();
            } while (!created);
        }

        //For loading a current save:
        private void Btn_loadSave_Click(object sender, EventArgs e)
        {
            _saveManager.SaveLocationAvailable(false);

            int saveValue = Cbx_loadSave.SelectedIndex; //Could change to .selectedItem, if using a "save" object/class
        }
    }
}