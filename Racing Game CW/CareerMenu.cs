using System.IO;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    public partial class CareerMenu : Form
    {
        public CareerMenu()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.DataGridView(Dgv_drivers);
            MenuUI.DataGridView(Dgv_constructors);

            //Just temporary code:
            Dgv_drivers.Columns.Clear();
            Dgv_drivers.AutoGenerateColumns = false;
            Dgv_drivers.Columns.Add("Team", "Team");
            Dgv_drivers.Columns.Add("Points", "Points");
            Dgv_drivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var path = Path.Combine("GameSaves", "fakesave.txt");
            if (!File.Exists(path)) return;

            using (var sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(new[] { ',' }, 2);
                    var team = parts[0].Trim();
                    int points = 0;
                    if (parts.Length > 1) int.TryParse(parts[1].Trim(), out points);
                    Dgv_drivers.Rows.Add(team, points);
                }
            }
        }

        private void Btn_nextRace_Click(object sender, System.EventArgs e)
        {
            Race race = new Race();
            this.Hide();
            race.Show();
            //Later it should go to race setup then actual race
        }
    }
}