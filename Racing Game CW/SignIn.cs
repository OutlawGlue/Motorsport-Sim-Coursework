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
            MenuUI.Panel(pnl_top);
            MenuUI.SecondaryPanel(pnl_bar);
            MenuUI.Button(btn_disabledSignIn);
            MenuUI.UnselectedButton(btn_register);
            MenuUI.BodyButton(btn_signIn);
            MenuUI.BodyLabel(lbl_username);
            MenuUI.BodyLabel(lbl_password);
            MenuUI.TextBox(tbx_username);
            MenuUI.TextBox(tbx_password);
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;

            if (_manager.SignIn(username, password))
            {
                //Sign in successful
                tbx_username.Clear();
                tbx_password.Clear();

                MainMenu menu = new MainMenu();
                this.Hide();
                menu.Show();
            }
            else
            {
                //Sign in failed
                //Don't display message, this is handled in user manager
                tbx_password.Clear();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            this.Hide();
            regForm.Show();
        }
    }
}