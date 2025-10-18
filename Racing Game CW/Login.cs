using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Racing_Game_CW
{
    public partial class Login : Form
    {
        private UserManager manager = new UserManager();   
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;

            if(manager.Login(username, password))
            {
                //Login successful
            }
            else
            {
                //Login failed
                //Don't display message, this is handled in user manager
            }
        }
    }
}
