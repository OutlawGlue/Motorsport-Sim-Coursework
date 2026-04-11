using MotorsportSim.General;
using MotorsportSim.RaceSim;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MotorsportSim.Career
{
    public partial class CareerMenu : Form
    {
        private SaveManager _saveManager;
        private CareerSave save;

        public CareerMenu(string saveName, SaveManager _saveManager)
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.BodyButton(Btn_nextRace);
            MenuUI.BodyButton(Btn_back);
            MenuUI.DataGridView(Dgv_drivers);
            MenuUI.DataGridView(Dgv_constructors);

            //Just temporary code:
            Dgv_drivers.AutoGenerateColumns = false;
            Dgv_drivers.Columns.Clear();
            Dgv_drivers.Columns.Add("Driver", "Driver");
            Dgv_drivers.Columns.Add("Points", "Points");
            Dgv_drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Constructors:
            Dgv_constructors.AutoGenerateColumns = false;
            Dgv_constructors.Columns.Clear();
            Dgv_constructors.Columns.Add("Team", "Team");
            Dgv_constructors.Columns.Add("Points", "Points");
            Dgv_constructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Use save manager to load in data:
            this._saveManager = _saveManager;
            save = _saveManager.LoadSave(saveName);
            save.InitialiseStandings();

            //Load data into dgv's:
            PopulateTables();
            
        }

        private void Btn_nextRace_Click(object sender, System.EventArgs e)
        {
            //Load into next race:
            TrackLoader loader = new TrackLoader();
            Track nextTrack = loader.LoadTrack(save.CurrentRound);

            RaceConfig settings = new RaceConfig(nextTrack, save.LapCount, save.ManagedTeamIndex, save.Teams);

            this.Hide();
            Race race = new Race(settings, save);
            race.ShowDialog();

            this.Show();

            save.CurrentRound++;
            PopulateTables();
            UpdateSaveFile();
            //Code saving everything from race, and being able to continue in your career.
        }

        private void UpdateSaveFile()
        {
            //Only needs to write to the file, not update save instance
            _saveManager.SaveCareer(save);
        }

        private void PopulateTables()
        {
            if (save.DriverStandings == null)
                return;

            //Drivers:
            Dgv_drivers.Rows.Clear();

            foreach (DriverStanding standing in save.DriverStandings.OrderByDescending(s => s.Points))
            {
                Driver driver = save.Teams
                    .SelectMany(t => t.Drivers)
                    .FirstOrDefault(d => d.Number == standing.DriverNumber);

                if (driver != null)
                {
                    Dgv_drivers.Rows.Add(driver.Name, standing.Points);
                }
            }

            //Constructors:
            Dictionary<string, int> teamPoints = new Dictionary<string, int>();

            foreach (Team team in save.Teams)
            {
                teamPoints[team.Name] = 0;

                foreach (Driver driver in team.Drivers)
                {
                    DriverStanding standing = save.DriverStandings
                        .FirstOrDefault(s => s.DriverNumber == driver.Number);

                    if (standing != null)
                    {
                        teamPoints[team.Name] += standing.Points;
                    }
                }
            }

            Dgv_constructors.Rows.Clear();

            foreach (var team in teamPoints.OrderByDescending(t => t.Value))
            {
                Dgv_constructors.Rows.Add(team.Key, team.Value);
            }
        }

        private void Btn_back_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}