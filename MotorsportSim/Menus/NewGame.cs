using MotorsportSim.Career;
using MotorsportSim.General;
using MotorsportSim.QuickRace;
using System;
using System.Windows.Forms;

namespace MotorsportSim.Menus
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.BodyButton(Btn_career);
            MenuUI.BodyButton(Btn_quickRace);
            MenuUI.BodyButton(Btn_back);
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();
        }

        private void Btn_career_Click(object sender, EventArgs e)
        {
            CareerManager careerManager = new CareerManager();
            this.Close();
            careerManager.ShowDialog();
        }

        private void Btn_quickRace_Click(object sender, EventArgs e)
        {
            QuickRaceSetup quickRaceSetup = new QuickRaceSetup();
            this.Close();
            quickRaceSetup.ShowDialog();
        }
    }
}