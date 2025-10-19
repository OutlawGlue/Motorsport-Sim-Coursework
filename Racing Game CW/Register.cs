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
    public partial class Register : Form
    {
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
    }
}