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
    public partial class SignIn : Form
    {
        private UserManager manager = new UserManager();   
        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            string username = tbx_username.Text;
            string password = tbx_password.Text;

            if(manager.SignIn(username, password))
            {
                //Sign in successful
            }
            else
            {
                //Sign in failed
                //Don't display message, this is handled in user manager
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
