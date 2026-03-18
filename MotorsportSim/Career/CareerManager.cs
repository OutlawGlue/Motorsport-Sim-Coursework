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
        private readonly SaveManager _saveManager = new SaveManager();

        public CareerManager()
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
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Cbx_loadCareer.Items.Clear();
            string[] files = _saveManager.LoadSaveList();
            foreach (string file in files)
            {
                Cbx_loadCareer.Items.Add(Path.GetFileNameWithoutExtension(file));
            }

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

        //For creating a new save:
        private void Btn_newSave_Click(object sender, EventArgs e)
        {
            //Validate the save name first (could do all these processes in saveManager)

            //Make sure there is a folder to save files in:
            _saveManager.SaveLocationAvailable(true);

            bool created;
            do
            {
                string saveName = Tbx_saveName.Text;
                int lapCount = int.Parse(Cbx_lapCount.Text);
                int teamCount = int.Parse(Cbx_teamCount.Text);
                int managedTeamIndex = Cbx_managedTeam.SelectedIndex;

                List<Team> teams = _saveManager.LoadTeamList(teamCount, managedTeamIndex);
                DateTime currentDate = DateTime.Now;
                CareerSave newSave = new CareerSave(saveName, currentDate, lapCount, teams, managedTeamIndex);
                created = _saveManager.CreateNewSave(saveName, newSave);
                Tbx_saveName.Clear();
            } while (!created);
        }

        //For loading a current save:
        private void Btn_loadSave_Click(object sender, EventArgs e)
        {
            _saveManager.SaveLocationAvailable(false);

            string saveValue = Cbx_loadCareer.SelectedItem.ToString(); //Outputs an object, but itll just be eg."save"

            CareerMenu careerMenu = new CareerMenu(saveValue);
            this.Close();
            careerMenu.ShowDialog();
        }

        private void Btn_settings_Click(object sender, EventArgs e)
        {
            //Does this change menu settings? Currently selected save settings?
            //Probably menu settings, as save settings would be in-game
            //If so, this should be accessible in all menus (once logged in)
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            this.Close();
            newGame.ShowDialog();
        }
    }
}