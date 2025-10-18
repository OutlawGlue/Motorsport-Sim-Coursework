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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private List<User> ReturnUsers()
        {
            List<User> users = new List<User>();
            using (StreamReader sr = new StreamReader("Users.txt"))
            {

            }


            return users;
        }
    }
}
