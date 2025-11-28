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
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Pnl_bar = new System.Windows.Forms.Panel();
            this.Btn_disabledSignIn = new System.Windows.Forms.Button();
            this.Btn_register = new System.Windows.Forms.Button();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_password = new System.Windows.Forms.Label();
            this.Tbx_username = new System.Windows.Forms.TextBox();
            this.Tbx_password = new System.Windows.Forms.TextBox();
            this.Btn_signIn = new System.Windows.Forms.Button();
            this.Pnl_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 4;
            // 
            // pnl_bar
            // 
            this.Pnl_bar.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_bar.Controls.Add(this.Btn_disabledSignIn);
            this.Pnl_bar.Controls.Add(this.Btn_register);
            this.Pnl_bar.Location = new System.Drawing.Point(0, 135);
            this.Pnl_bar.Name = "pnl_bar";
            this.Pnl_bar.Size = new System.Drawing.Size(1380, 80);
            this.Pnl_bar.TabIndex = 5;
            // 
            // btn_disabledSignIn
            // 
            this.Btn_disabledSignIn.Location = new System.Drawing.Point(530, 0);
            this.Btn_disabledSignIn.Name = "btn_disabledSignIn";
            this.Btn_disabledSignIn.Size = new System.Drawing.Size(150, 80);
            this.Btn_disabledSignIn.TabIndex = 11;
            this.Btn_disabledSignIn.Text = "Sign In";
            this.Btn_disabledSignIn.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.Btn_register.Location = new System.Drawing.Point(700, 0);
            this.Btn_register.Name = "btn_register";
            this.Btn_register.Size = new System.Drawing.Size(150, 80);
            this.Btn_register.TabIndex = 3;
            this.Btn_register.Text = "Register";
            this.Btn_register.UseVisualStyleBackColor = true;
            this.Btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Location = new System.Drawing.Point(530, 320);
            this.Lbl_username.Name = "lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(83, 20);
            this.Lbl_username.TabIndex = 3;
            this.Lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.Lbl_password.AutoSize = true;
            this.Lbl_password.Location = new System.Drawing.Point(530, 440);
            this.Lbl_password.Name = "lbl_password";
            this.Lbl_password.Size = new System.Drawing.Size(78, 20);
            this.Lbl_password.TabIndex = 13;
            this.Lbl_password.Text = "Password";
            // 
            // tbx_username
            // 
            this.Tbx_username.Location = new System.Drawing.Point(530, 360);
            this.Tbx_username.MaxLength = 15;
            this.Tbx_username.Name = "tbx_username";
            this.Tbx_username.Size = new System.Drawing.Size(320, 26);
            this.Tbx_username.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.Tbx_password.Location = new System.Drawing.Point(530, 480);
            this.Tbx_password.MaxLength = 30;
            this.Tbx_password.Name = "tbx_password";
            this.Tbx_password.Size = new System.Drawing.Size(320, 26);
            this.Tbx_password.TabIndex = 1;
            // 
            // btn_signIn
            // 
            this.Btn_signIn.Location = new System.Drawing.Point(625, 600);
            this.Btn_signIn.Name = "btn_signIn";
            this.Btn_signIn.Size = new System.Drawing.Size(150, 40);
            this.Btn_signIn.TabIndex = 2;
            this.Btn_signIn.Text = "Sign In";
            this.Btn_signIn.UseVisualStyleBackColor = true;
            this.Btn_signIn.Click += new System.EventHandler(this.Btn_signIn_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Btn_signIn);
            this.Controls.Add(this.Tbx_password);
            this.Controls.Add(this.Tbx_username);
            this.Controls.Add(this.Lbl_password);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.Pnl_bar);
            this.Controls.Add(this.Pnl_top);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Pnl_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Panel Pnl_bar;
        private System.Windows.Forms.Button Btn_disabledSignIn;
        private System.Windows.Forms.Button Btn_register;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_password;
        private System.Windows.Forms.TextBox Tbx_username;
        private System.Windows.Forms.TextBox Tbx_password;
        private System.Windows.Forms.Button Btn_signIn;
    }
}

