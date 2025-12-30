namespace MotorsportSim.Menus
{
    partial class Register
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
            this.Tbx_password = new System.Windows.Forms.TextBox();
            this.Tbx_username = new System.Windows.Forms.TextBox();
            this.Lbl_password = new System.Windows.Forms.Label();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Pnl_bar = new System.Windows.Forms.Panel();
            this.Btn_signIn = new System.Windows.Forms.Button();
            this.Btn_disabledRegister = new System.Windows.Forms.Button();
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Lbl_confirmPassword = new System.Windows.Forms.Label();
            this.Tbx_confirmPassword = new System.Windows.Forms.TextBox();
            this.Btn_register = new System.Windows.Forms.Button();
            this.Pnl_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_password
            // 
            this.Tbx_password.Location = new System.Drawing.Point(530, 440);
            this.Tbx_password.MaxLength = 30;
            this.Tbx_password.Name = "tbx_password";
            this.Tbx_password.Size = new System.Drawing.Size(300, 26);
            this.Tbx_password.TabIndex = 1;
            // 
            // tbx_username
            // 
            this.Tbx_username.Location = new System.Drawing.Point(530, 320);
            this.Tbx_username.MaxLength = 15;
            this.Tbx_username.Name = "tbx_username";
            this.Tbx_username.Size = new System.Drawing.Size(300, 26);
            this.Tbx_username.TabIndex = 0;
            // 
            // lbl_password
            // 
            this.Lbl_password.AutoSize = true;
            this.Lbl_password.Location = new System.Drawing.Point(530, 400);
            this.Lbl_password.Name = "lbl_password";
            this.Lbl_password.Size = new System.Drawing.Size(78, 20);
            this.Lbl_password.TabIndex = 19;
            this.Lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Location = new System.Drawing.Point(530, 280);
            this.Lbl_username.Name = "lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(83, 20);
            this.Lbl_username.TabIndex = 16;
            this.Lbl_username.Text = "Username";
            // 
            // pnl_bar
            // 
            this.Pnl_bar.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_bar.Controls.Add(this.Btn_signIn);
            this.Pnl_bar.Controls.Add(this.Btn_disabledRegister);
            this.Pnl_bar.Location = new System.Drawing.Point(0, 135);
            this.Pnl_bar.Name = "pnl_bar";
            this.Pnl_bar.Size = new System.Drawing.Size(1380, 80);
            this.Pnl_bar.TabIndex = 18;
            // 
            // btn_signIn
            // 
            this.Btn_signIn.Location = new System.Drawing.Point(530, 0);
            this.Btn_signIn.Name = "btn_signIn";
            this.Btn_signIn.Size = new System.Drawing.Size(150, 80);
            this.Btn_signIn.TabIndex = 3;
            this.Btn_signIn.Text = "Sign In";
            this.Btn_signIn.UseVisualStyleBackColor = true;
            this.Btn_signIn.Click += new System.EventHandler(this.Btn_signIn_Click);
            // 
            // btn_disabledRegister
            // 
            this.Btn_disabledRegister.Location = new System.Drawing.Point(700, 0);
            this.Btn_disabledRegister.Name = "btn_disabledRegister";
            this.Btn_disabledRegister.Size = new System.Drawing.Size(150, 80);
            this.Btn_disabledRegister.TabIndex = 20;
            this.Btn_disabledRegister.Text = "Register";
            this.Btn_disabledRegister.UseVisualStyleBackColor = true;
            // 
            // pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 17;
            // 
            // lbl_confirmPassword
            // 
            this.Lbl_confirmPassword.AutoSize = true;
            this.Lbl_confirmPassword.Location = new System.Drawing.Point(530, 500);
            this.Lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.Lbl_confirmPassword.Size = new System.Drawing.Size(137, 20);
            this.Lbl_confirmPassword.TabIndex = 20;
            this.Lbl_confirmPassword.Text = "Confirm Password";
            // 
            // tbx_confirmPassword
            // 
            this.Tbx_confirmPassword.Location = new System.Drawing.Point(530, 540);
            this.Tbx_confirmPassword.MaxLength = 30;
            this.Tbx_confirmPassword.Name = "tbx_confirmPassword";
            this.Tbx_confirmPassword.Size = new System.Drawing.Size(300, 26);
            this.Tbx_confirmPassword.TabIndex = 2;
            // 
            // btn_register
            // 
            this.Btn_register.Location = new System.Drawing.Point(600, 640);
            this.Btn_register.Name = "btn_register";
            this.Btn_register.Size = new System.Drawing.Size(150, 40);
            this.Btn_register.TabIndex = 3;
            this.Btn_register.Text = "Register";
            this.Btn_register.UseVisualStyleBackColor = true;
            this.Btn_register.Click += new System.EventHandler(this.Btn_register_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Btn_register);
            this.Controls.Add(this.Tbx_confirmPassword);
            this.Controls.Add(this.Lbl_confirmPassword);
            this.Controls.Add(this.Tbx_password);
            this.Controls.Add(this.Tbx_username);
            this.Controls.Add(this.Lbl_password);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.Pnl_bar);
            this.Controls.Add(this.Pnl_top);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Pnl_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_password;
        private System.Windows.Forms.TextBox Tbx_username;
        private System.Windows.Forms.Label Lbl_password;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Panel Pnl_bar;
        private System.Windows.Forms.Button Btn_signIn;
        private System.Windows.Forms.Button Btn_disabledRegister;
        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Label Lbl_confirmPassword;
        private System.Windows.Forms.TextBox Tbx_confirmPassword;
        private System.Windows.Forms.Button Btn_register;
    }
}