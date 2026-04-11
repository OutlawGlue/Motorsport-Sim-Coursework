using MotorsportSim.Career;
using MotorsportSim.General;
using MotorsportSim.QuickRace;
using System;
using System.Windows.Forms;

namespace MotorsportSim.Menus
{
    public partial class NewGame : Form
    {
        private string username;
        public NewGame(string username)
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.BodyButton(Btn_career);
            MenuUI.BodyButton(Btn_quickRace);
            MenuUI.BodyButton(Btn_back);

            this.username = username;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Close();
            signIn.Show();
        }

        private void Btn_career_Click(object sender, EventArgs e)
        {
            this.Hide();

            CareerManager careerManager = new CareerManager(username);
            careerManager.ShowDialog();

            this.Show();
        }

        private void Btn_quickRace_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuickRaceSetup quickRaceSetup = new QuickRaceSetup();
            quickRaceSetup.ShowDialog();

            this.Show();
        }
    }
}