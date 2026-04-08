using MotorsportSim.General;
using MotorsportSim.QuickRace;
using MotorsportSim.RaceSim;
using System.IO;
using System.Windows.Forms;

namespace MotorsportSim.Career
{
    public partial class CareerMenu : Form
    {
        private CareerSave save;

        public CareerMenu(string saveName)
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

            //Use save manager to load in data
            SaveManager _saveManager = new SaveManager();
            save = _saveManager.LoadSave(saveName);
        }

        private void Btn_nextRace_Click(object sender, System.EventArgs e)
        {
            //TEMPORARY, will already be used before here
            RaceConfig raceConfig = new RaceConfig(save.NextTrack, save.LapCount, save.ManagedTeamIndex, save.Teams);

            Race race = new Race(raceConfig);
            this.Close();
            race.ShowDialog();
            //Later it should go to race setup then actual race,
            //if career allows different settings, rather than  one consistent setup
        }
    }
}