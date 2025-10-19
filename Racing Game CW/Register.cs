using System;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    public partial class Register : Form
    {
        private UserManager _manager = new UserManager();

        public Register()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(pnl_top);
            MenuUI.SecondaryPanel(pnl_bar);
            MenuUI.UnselectedButton(btn_signIn);
            MenuUI.Button(btn_disabledRegister);
            MenuUI.BodyButton(btn_register);
            MenuUI.BodyLabel(lbl_username);
            MenuUI.BodyLabel(lbl_password);
            MenuUI.BodyLabel(lbl_confirmPassword);
            MenuUI.TextBox(tbx_username);
            MenuUI.TextBox(tbx_password);
            MenuUI.TextBox(tbx_confirmPassword);
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;
            string confirmPassword = tbx_confirmPassword.Text;

            if (_manager.CreateAccount(username, password, confirmPassword))
            {
                //Account successfully created, message already handled in user manager
                tbx_username.Clear();
                tbx_password.Clear();
                tbx_confirmPassword.Clear();

                //Open menu
            }
            else
            {
                //Account creation failed
            }
        }
    }
}