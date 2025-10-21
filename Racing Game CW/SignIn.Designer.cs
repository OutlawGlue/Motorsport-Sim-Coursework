namespace Racing_Game_CW
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bar = new System.Windows.Forms.Panel();
            this.btn_disabledSignIn = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.pnl_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.White;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(900, 88);
            this.pnl_top.TabIndex = 4;
            // 
            // pnl_bar
            // 
            this.pnl_bar.BackColor = System.Drawing.Color.White;
            this.pnl_bar.Controls.Add(this.btn_disabledSignIn);
            this.pnl_bar.Controls.Add(this.btn_register);
            this.pnl_bar.Location = new System.Drawing.Point(0, 88);
            this.pnl_bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_bar.Name = "pnl_bar";
            this.pnl_bar.Size = new System.Drawing.Size(900, 52);
            this.pnl_bar.TabIndex = 5;
            // 
            // btn_disabledSignIn
            // 
            this.btn_disabledSignIn.Location = new System.Drawing.Point(350, 0);
            this.btn_disabledSignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_disabledSignIn.Name = "btn_disabledSignIn";
            this.btn_disabledSignIn.Size = new System.Drawing.Size(100, 52);
            this.btn_disabledSignIn.TabIndex = 11;
            this.btn_disabledSignIn.Text = "Sign In";
            this.btn_disabledSignIn.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(450, 0);
            this.btn_register.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(100, 52);
            this.btn_register.TabIndex = 3;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(355, 208);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(355, 286);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 13;
            this.lbl_password.Text = "Password";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(350, 234);
            this.tbx_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_username.MaxLength = 15;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(202, 20);
            this.tbx_username.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(350, 312);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_password.MaxLength = 30;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(202, 20);
            this.tbx_password.TabIndex = 1;
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(400, 390);
            this.btn_signIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(100, 26);
            this.btn_signIn.TabIndex = 2;
            this.btn_signIn.Text = "Sign In";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pnl_bar);
            this.Controls.Add(this.pnl_top);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bar;
        private System.Windows.Forms.Button btn_disabledSignIn;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_signIn;
    }
}

