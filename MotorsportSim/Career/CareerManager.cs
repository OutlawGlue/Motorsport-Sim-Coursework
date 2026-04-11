using MotorsportSim.General;
using MotorsportSim.Menus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MotorsportSim.RaceSim;

namespace MotorsportSim.Career
{
    public partial class CareerManager : Form
    {
        private readonly SaveManager _saveManager;

        public CareerManager(string username)
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.SecondaryPanel(Pnl_sideBar);
            MenuUI.BodyButton(Btn_newCareer);
            MenuUI.Button(Btn_loadCareer);
            MenuUI.Button(Btn_settings);
            MenuUI.Button(Btn_back);
            MenuUI.ComboBox(Cbx_loadCareer);
            MenuUI.HeadingLabel(Lbl_newCareer);
            MenuUI.TextBox(Tbx_saveName);
            MenuUI.ComboBox(Cbx_lapCount);
            MenuUI.ComboBox(Cbx_teamCount);
            MenuUI.ComboBox(Cbx_managedTeam);
            MenuUI.BodyLabel(Lbl_careerName);
            MenuUI.BodyLabel(Lbl_lapCount);
            MenuUI.BodyLabel(Lbl_teams);
            MenuUI.BodyLabel(Lbl_managedTeam);

            _saveManager = new SaveManager(username);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadBoxes();
        }

        //For creating a new save:
        private void Btn_newSave_Click(object sender, EventArgs e)
        {
            //Make sure there is a folder to save files in:
            _saveManager.SaveLocationAvailable(true);

            bool created; string saveName;
            do
            {
                saveName = Tbx_saveName.Text;
                int lapCount = int.Parse(Cbx_lapCount.Text);
                int teamCount = int.Parse(Cbx_teamCount.Text);
                int managedTeamIndex = Cbx_managedTeam.SelectedIndex;

                List<Team> teams = _saveManager.LoadTeamList(teamCount, managedTeamIndex);
                CareerSave newSave = new CareerSave(saveName, lapCount, teams, managedTeamIndex);
                created = _saveManager.CreateNewSave(saveName, newSave); //Handles MsgBox
                Tbx_saveName.Clear();
            } while (!created);

            LoadSaves();
            LoadGame(saveName);
        }

        private void LoadSaves()
        {
            Cbx_loadCareer.Items.Clear();
            string[] files = _saveManager.LoadSaveList();
            foreach (string file in files)
            {
                Cbx_loadCareer.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void LoadBoxes()
        {
            LoadSaves();

            Cbx_lapCount.Items.Clear();
            int[] laps = { 3, 5, 10, 20 };
            foreach (int lap in laps)
            {
                Cbx_lapCount.Items.Add(lap);
            }

            Cbx_teamCount.Items.Clear();
            int[] teams = { 4, 6, 8, 10 };
            foreach (int team in teams)
            {
                Cbx_teamCount.Items.Add(team);
            }

            Cbx_managedTeam.Items.Clear();
            List<BasicTeam> teamList = _saveManager.LoadBasicTeamList();
            foreach (BasicTeam team in teamList)
            {
                Cbx_managedTeam.Items.Add(team.TeamName);
            }
        }

        //For loading a current save:
        private void Btn_loadSave_Click(object sender, EventArgs e)
        {
            LoadGame();
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            //Does this change menu settings? Currently selected save settings?
            //Probably menu settings, as save settings would be in-game
            //If so, this should be accessible in all menus (once logged in)
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadGame(string saveValue = null)
        {
            _saveManager.SaveLocationAvailable(false);

            if (saveValue == null)
            {
                //IE re loading an existing save:
                saveValue = Cbx_loadCareer.SelectedItem.ToString(); //Outputs an object, but itll just be eg."save"
            }

            this.Hide();

            CareerMenu careerMenu = new CareerMenu(saveValue, _saveManager);
            careerMenu.ShowDialog();

            this.Close();
        }
    }
}