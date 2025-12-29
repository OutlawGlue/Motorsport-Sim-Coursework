using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racing_Game_CW
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
            this.Hide();
            signIn.Show();
        }

        private void Btn_career_Click(object sender, EventArgs e)
        {
            CareerManager careerManager = new CareerManager();
            this.Hide();
            careerManager.Show();
        }

        private void Btn_quickRace_Click(object sender, EventArgs e)
        {
            QuickRaceSetup quickRaceSetup = new QuickRaceSetup();
            this.Hide();
            quickRaceSetup.Show();
        }
    }
}