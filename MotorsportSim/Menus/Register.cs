using MotorsportSim.General;
using System;
using System.Windows.Forms;

namespace MotorsportSim.Menus
{
    public partial class Register : Form
    {
        private UserManager _manager = new UserManager();

        public Register()
        {
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_top);
            MenuUI.SecondaryPanel(Pnl_bar);
            MenuUI.UnselectedButton(Btn_signIn);
            MenuUI.Button(Btn_disabledRegister);
            MenuUI.BodyButton(Btn_register);
            MenuUI.BodyLabel(Lbl_username);
            MenuUI.BodyLabel(Lbl_password);
            MenuUI.BodyLabel(Lbl_confirmPassword);
            MenuUI.TextBox(Tbx_username);
            MenuUI.TextBox(Tbx_password);
            MenuUI.TextBox(Tbx_confirmPassword);
        }

        private void Btn_signIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Close();
            signIn.ShowDialog();
        }

        private void Btn_register_Click(object sender, EventArgs e)
        {
            string username = Tbx_username.Text;
            string password = Tbx_password.Text;
            string confirmPassword = Tbx_confirmPassword.Text;

            if (_manager.CreateAccount(username, password, confirmPassword))
            {
                //Account successfully created, message already handled in user manager
                Tbx_username.Clear();
                Tbx_password.Clear();
                Tbx_confirmPassword.Clear();

                NewGame menu = new NewGame(username);
                this.Close();
                menu.ShowDialog();
            }
            else
            {
                //Account creation failed
                //Message already comes from user manager
            }
        }
    }
}