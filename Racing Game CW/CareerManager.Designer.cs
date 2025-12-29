
namespace Racing_Game_CW
{
    partial class CareerManager
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
            this.Pnl_sideBar = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Cbx_loadCareer = new System.Windows.Forms.ComboBox();
            this.Btn_settings = new System.Windows.Forms.Button();
            this.Btn_loadCareer = new System.Windows.Forms.Button();
            this.Btn_newCareer = new System.Windows.Forms.Button();
            this.Lbl_newCareer = new System.Windows.Forms.Label();
            this.tbx_saveName = new System.Windows.Forms.TextBox();
            this.Lbl_careerName = new System.Windows.Forms.Label();
            this.Pnl_sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "Pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 18;
            // 
            // Pnl_sideBar
            // 
            this.Pnl_sideBar.Controls.Add(this.Btn_back);
            this.Pnl_sideBar.Controls.Add(this.Cbx_loadCareer);
            this.Pnl_sideBar.Controls.Add(this.Btn_settings);
            this.Pnl_sideBar.Controls.Add(this.Btn_loadCareer);
            this.Pnl_sideBar.Location = new System.Drawing.Point(0, 135);
            this.Pnl_sideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl_sideBar.Name = "Pnl_sideBar";
            this.Pnl_sideBar.Size = new System.Drawing.Size(240, 650);
            this.Pnl_sideBar.TabIndex = 6;
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(20, 560);
            this.Btn_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(200, 40);
            this.Btn_back.TabIndex = 20;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Cbx_loadCareer
            // 
            this.Cbx_loadCareer.FormattingEnabled = true;
            this.Cbx_loadCareer.Location = new System.Drawing.Point(20, 120);
            this.Cbx_loadCareer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Cbx_loadCareer.Name = "Cbx_loadCareer";
            this.Cbx_loadCareer.Size = new System.Drawing.Size(200, 28);
            this.Cbx_loadCareer.TabIndex = 19;
            // 
            // Btn_settings
            // 
            this.Btn_settings.Location = new System.Drawing.Point(20, 510);
            this.Btn_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_settings.Name = "Btn_settings";
            this.Btn_settings.Size = new System.Drawing.Size(200, 40);
            this.Btn_settings.TabIndex = 9;
            this.Btn_settings.Text = "Settings";
            this.Btn_settings.UseVisualStyleBackColor = true;
            this.Btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // Btn_loadCareer
            // 
            this.Btn_loadCareer.Location = new System.Drawing.Point(20, 80);
            this.Btn_loadCareer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.Btn_loadCareer.Name = "Btn_loadCareer";
            this.Btn_loadCareer.Size = new System.Drawing.Size(200, 40);
            this.Btn_loadCareer.TabIndex = 8;
            this.Btn_loadCareer.Text = "Load Selected Career";
            this.Btn_loadCareer.UseVisualStyleBackColor = true;
            this.Btn_loadCareer.Click += new System.EventHandler(this.Btn_loadSave_Click);
            // 
            // Btn_newCareer
            // 
            this.Btn_newCareer.Location = new System.Drawing.Point(695, 650);
            this.Btn_newCareer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_newCareer.Name = "Btn_newCareer";
            this.Btn_newCareer.Size = new System.Drawing.Size(250, 50);
            this.Btn_newCareer.TabIndex = 7;
            this.Btn_newCareer.Text = "Create New Career";
            this.Btn_newCareer.UseVisualStyleBackColor = true;
            this.Btn_newCareer.Click += new System.EventHandler(this.Btn_newSave_Click);
            // 
            // Lbl_newCareer
            // 
            this.Lbl_newCareer.AutoSize = true;
            this.Lbl_newCareer.Location = new System.Drawing.Point(780, 230);
            this.Lbl_newCareer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_newCareer.Name = "Lbl_newCareer";
            this.Lbl_newCareer.Size = new System.Drawing.Size(92, 20);
            this.Lbl_newCareer.TabIndex = 19;
            this.Lbl_newCareer.Text = "New Career";
            // 
            // tbx_saveName
            // 
            this.tbx_saveName.Location = new System.Drawing.Point(670, 270);
            this.tbx_saveName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_saveName.Name = "tbx_saveName";
            this.tbx_saveName.Size = new System.Drawing.Size(300, 26);
            this.tbx_saveName.TabIndex = 20;
            // 
            // Lbl_careerName
            // 
            this.Lbl_careerName.AutoSize = true;
            this.Lbl_careerName.Location = new System.Drawing.Point(550, 270);
            this.Lbl_careerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_careerName.Name = "Lbl_careerName";
            this.Lbl_careerName.Size = new System.Drawing.Size(107, 20);
            this.Lbl_careerName.TabIndex = 21;
            this.Lbl_careerName.Text = "Career Name:";
            // 
            // CareerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Lbl_careerName);
            this.Controls.Add(this.tbx_saveName);
            this.Controls.Add(this.Lbl_newCareer);
            this.Controls.Add(this.Pnl_top);
            this.Controls.Add(this.Pnl_sideBar);
            this.Controls.Add(this.Btn_newCareer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CareerManager";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Pnl_sideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Panel Pnl_sideBar;
        private System.Windows.Forms.Button Btn_newCareer;
        private System.Windows.Forms.Button Btn_loadCareer;
        private System.Windows.Forms.Button Btn_settings;
        private System.Windows.Forms.ComboBox Cbx_loadCareer;
        private System.Windows.Forms.Label Lbl_newCareer;
        private System.Windows.Forms.TextBox tbx_saveName;
        private System.Windows.Forms.Label Lbl_careerName;
        private System.Windows.Forms.Button Btn_back;
    }
}