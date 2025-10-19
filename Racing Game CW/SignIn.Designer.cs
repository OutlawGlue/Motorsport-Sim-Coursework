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
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bar = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_disabledSignIn = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.pnl_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.tbx_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_username.Font = new System.Drawing.Font("Audiowide", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(700, 450);
            this.tbx_username.MaxLength = 15;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(400, 42);
            this.tbx_username.TabIndex = 0;
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.tbx_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_password.Font = new System.Drawing.Font("Audiowide", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(700, 600);
            this.tbx_password.MaxLength = 30;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(400, 42);
            this.tbx_password.TabIndex = 1;
            // 
            // btn_signIn
            // 
            this.btn_signIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.btn_signIn.FlatAppearance.BorderSize = 0;
            this.btn_signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signIn.Font = new System.Drawing.Font("Audiowide", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.btn_signIn.Location = new System.Drawing.Point(800, 680);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(200, 50);
            this.btn_signIn.TabIndex = 2;
            this.btn_signIn.Text = "Sign In";
            this.btn_signIn.UseVisualStyleBackColor = false;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(19)))), ((int)(((byte)(33)))));
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1774, 170);
            this.pnl_top.TabIndex = 4;
            // 
            // pnl_bar
            // 
            this.pnl_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(45)))), ((int)(((byte)(68)))));
            this.pnl_bar.Controls.Add(this.btn_register);
            this.pnl_bar.Controls.Add(this.btn_disabledSignIn);
            this.pnl_bar.Location = new System.Drawing.Point(0, 170);
            this.pnl_bar.Name = "pnl_bar";
            this.pnl_bar.Size = new System.Drawing.Size(1774, 100);
            this.pnl_bar.TabIndex = 5;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Audiowide", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.lbl_username.Location = new System.Drawing.Point(710, 400);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(166, 35);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.Font = new System.Drawing.Font("Audiowide", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.lbl_password.Location = new System.Drawing.Point(710, 550);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(164, 35);
            this.lbl_password.TabIndex = 8;
            this.lbl_password.Text = "Password";
            // 
            // btn_disabledSignIn
            // 
            this.btn_disabledSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_disabledSignIn.FlatAppearance.BorderSize = 0;
            this.btn_disabledSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disabledSignIn.Font = new System.Drawing.Font("Audiowide", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disabledSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.btn_disabledSignIn.Location = new System.Drawing.Point(700, 0);
            this.btn_disabledSignIn.Name = "btn_disabledSignIn";
            this.btn_disabledSignIn.Size = new System.Drawing.Size(200, 100);
            this.btn_disabledSignIn.TabIndex = 9;
            this.btn_disabledSignIn.Text = "Sign In";
            this.btn_disabledSignIn.UseVisualStyleBackColor = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Audiowide", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.btn_register.Location = new System.Drawing.Point(900, 0);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(200, 100);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1774, 929);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pnl_bar);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnl_bar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_signIn;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bar;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_disabledSignIn;
        private System.Windows.Forms.Button btn_register;
    }
}

