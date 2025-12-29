using System;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    public partial class SignIn : Form
    {
        private readonly UserManager _manager = new UserManager();

        public SignIn()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.SecondaryPanel(Pnl_bar);
            MenuUI.Button(Btn_disabledSignIn);
            MenuUI.UnselectedButton(Btn_register);
            MenuUI.BodyButton(Btn_signIn);
            MenuUI.BodyLabel(Lbl_username);
            MenuUI.BodyLabel(Lbl_password);
            MenuUI.TextBox(Tbx_username);
            MenuUI.TextBox(Tbx_password);
        }

        private void Btn_signIn_Click(object sender, EventArgs e)
        {
            string username = Tbx_username.Text;
            string password = Tbx_password.Text;

            if (_manager.SignIn(username, password))
            {
                //Sign in successful
                Tbx_username.Clear();
                Tbx_password.Clear();

                NewGame menu = new NewGame();
                this.Hide();
                menu.Show();
            }
            else
            {
                //Sign in failed
                //Don't display message, this is handled in user manager
                Tbx_password.Clear();
            }
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            this.Hide();
            regForm.Show();
        }
    }
}