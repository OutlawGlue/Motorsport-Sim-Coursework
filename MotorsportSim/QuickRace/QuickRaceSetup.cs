using MotorsportSim.General;
using MotorsportSim.RaceSim;
using System;
using System.Windows.Forms;

namespace MotorsportSim.QuickRace
{
    public partial class QuickRaceSetup : Form
    {
        public QuickRaceSetup()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.ComboBox(Cbx_lapCount);
            MenuUI.BodyButton(Btn_startRace);
        }

        private void QuickRaceSetup_Load(object sender, System.EventArgs e)
        {
            //Set up combo boxes:
            Cbx_lapCount.Items.Clear();
            string[] lapOptions = { "3", "5", "10" };
            foreach (string laps in lapOptions)
            {
                Cbx_lapCount.Items.Add(laps);
            }
            Cbx_lapCount.SelectedIndex = 0;

            Cbx_carCount.Items.Clear();
            string[] countOptions = { "4", "6", "8" };
            foreach (string count in countOptions)
            {
                Cbx_carCount.Items.Add(count);
            }
            Cbx_carCount.SelectedIndex = 0;

            Cbx_teamIndex.Items.Clear();
            string[] teamOptions = { "McLaren", "Mercedes", "Red Bull", "Ferrari" }; //Will later be read in from text file, then database
            foreach (string team in teamOptions)
            {
                Cbx_teamIndex.Items.Add(team);
            }
            Cbx_teamIndex.SelectedIndex = 0;
        }

        private void Btn_startRace_Click(object sender, System.EventArgs e)
        {
            //Might not need this section if using default selections
            if (Cbx_lapCount.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a valid number of laps.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get selected values:
            string selectedLaps = Cbx_lapCount.SelectedItem.ToString();
            if (!int.TryParse(selectedLaps, out int laps))
            {
                MessageBox.Show("Please select a valid number of laps.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedCarCount = Cbx_carCount.SelectedItem.ToString();
            if (!int.TryParse(selectedCarCount, out int carCount))
            {
                MessageBox.Show("Please select a valid number of cars.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int teamIndex = Cbx_teamIndex.SelectedIndex; //Assuming index corresponds to team

            RaceSettings settings = new RaceSettings(laps, carCount, teamIndex);
            Race race = new Race(settings);
            this.Close();
            race.ShowDialog();
        }
    }
}