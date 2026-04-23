using MotorsportSim.General;
using MotorsportSim.RaceSim;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MotorsportSim.QuickRace
{
    public partial class QuickRaceSetup : Form
    {
        private List<Team> loadedTeams;

        public QuickRaceSetup()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.HeadingLabel(Lbl_newQuickRace);
            MenuUI.ComboBox(Cbx_lapCount);
            MenuUI.ComboBox(Cbx_teamCount);
            MenuUI.ComboBox(Cbx_teamIndex);
            MenuUI.ComboBox(Cbx_track);
            MenuUI.BodyLabel(Lbl_lapCount);
            MenuUI.BodyLabel(Lbl_teamCount);
            MenuUI.BodyLabel(Lbl_teamIndex);
            MenuUI.BodyLabel(Lbl_track);
            MenuUI.BodyButton(Btn_back);
            MenuUI.BodyButton(Btn_startRace);
        }

        private void QuickRaceSetup_Load(object sender, System.EventArgs e)
        {
            ITeamLoader teamLoader = new TextFileTeamLoader("Teams.txt");
            loadedTeams = teamLoader.LoadTeams();
            //Set up combo boxes:
            Cbx_lapCount.Items.Clear();
            string[] lapOptions = { "3", "5", "10" };
            foreach (string laps in lapOptions)
            {
                Cbx_lapCount.Items.Add(laps);
            }
            Cbx_lapCount.SelectedIndex = 0;

            Cbx_teamCount.Items.Clear();
            string[] countOptions = { "4", "6", "8" };
            foreach (string count in countOptions)
            {
                Cbx_teamCount.Items.Add(count);
            }
            Cbx_teamCount.SelectedIndex = 0;

            Cbx_teamIndex.Items.Clear();
            foreach (Team team in loadedTeams)
            {
                Cbx_teamIndex.Items.Add(team.Name);
            }
            Cbx_teamIndex.SelectedIndex = 0;

            Cbx_track.Items.Clear();
            TrackLoader loader = new TrackLoader();
            List<string> tracks = loader.LoadAll();
            foreach (string track in tracks)
            {
                Cbx_track.Items.Add(track);
            }
            Cbx_track.SelectedIndex = 0;
        }

        private void Btn_startRace_Click(object sender, System.EventArgs e)
        {
            //Get selected values:
            string selectedLaps = Cbx_lapCount.SelectedItem.ToString();
            if (!int.TryParse(selectedLaps, out int laps))
            {
                MessageBox.Show("Please select a valid number of laps.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedTeamCount = Cbx_teamCount.SelectedItem.ToString();
            if (!int.TryParse(selectedTeamCount, out int teamCount))
            {
                MessageBox.Show("Please select a valid number of teams.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int teamIndex = Cbx_teamIndex.SelectedIndex; //Assuming index corresponds to team

            //Load the track waypoints in:
            int index = Cbx_track.SelectedIndex;
            Track track = new Track(index);
            track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Change to load different tracks later
            track.InitialisePit();

            //Load selected teams and drivers:
            List<Team> teams = SelectTeams(loadedTeams, teamCount, teamIndex);

            RaceConfig config = new RaceConfig(track, laps, teamIndex, teams);

            this.Hide();

            Race race = new Race(config);
            race.ShowDialog();

            this.Close();
        }

        private List<Team> SelectTeams(List<Team> loadedTeams, int teamCount, int teamIndex)
        {
            List<Team> selectedTeams = new List<Team>();

            if (teamIndex < teamCount)
            {
                for (int i = 0; i < teamCount; i++)
                {
                    selectedTeams.Add(loadedTeams[i]);
                }
            }
            else
            {
                for (int i = 0; i < teamCount - 1; i++)
                {
                    selectedTeams.Add(loadedTeams[i]);
                }
                selectedTeams.Add(loadedTeams[teamIndex]);
            }

            return selectedTeams;
        }

        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}