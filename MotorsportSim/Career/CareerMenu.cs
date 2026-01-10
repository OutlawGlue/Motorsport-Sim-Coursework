using MotorsportSim.General;
using MotorsportSim.QuickRace;
using MotorsportSim.RaceSim;
using System.IO;
using System.Windows.Forms;

namespace MotorsportSim.Career
{
    public partial class CareerMenu : Form
    {
        public CareerMenu()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.BodyButton(Btn_nextRace);
            MenuUI.DataGridView(Dgv_drivers);
            MenuUI.DataGridView(Dgv_constructors);

            //Just temporary code:
            Dgv_drivers.AutoGenerateColumns = false;
            Dgv_drivers.Columns.Clear();
            Dgv_drivers.Columns.Add("Team", "Team");
            Dgv_drivers.Columns.Add("Points", "Points");
            Dgv_drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            string path = Path.Combine("GameSaves", "fakesave.txt");
            if (!File.Exists(path)) return;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split(new[] { ',' }, 2);
                    string team = parts[0].Trim();
                    int points = 0;
                    if (parts.Length > 1) int.TryParse(parts[1].Trim(), out points);
                    Dgv_drivers.Rows.Add(team, points);
                }
            }
        }

        private void Btn_nextRace_Click(object sender, System.EventArgs e)
        {
            CareerSave save = new CareerSave("My Career"); //TEMPORARY, will already be used before here
            RaceSettings settings = new RaceSettings(save.LapCount, save.CarCount, save.ManagedTeamIndex);

            Race race = new Race(settings);
            this.Close();
            race.ShowDialog();
            //Later it should go to race setup then actual race,
            //if career allows different settings, rather than  one consistent setup
        }
    }
}