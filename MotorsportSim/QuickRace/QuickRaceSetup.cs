using MotorsportSim.General;
using MotorsportSim.RaceSim;
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
            Cbx_lapCount.Items.Clear();
            string[] lapOptions = { "3", "5", "10" };
            foreach (string laps in lapOptions)
            {
                Cbx_lapCount.Items.Add(laps);
            }
        }

        private void Btn_startRace_Click(object sender, System.EventArgs e)
        {
            string laps = Cbx_lapCount.SelectedItem.ToString();
            RaceSettings settings = new RaceSettings(int.Parse(laps));
            Race race = new Race(settings);
            this.Close();
            race.ShowDialog();
        }
    }
}