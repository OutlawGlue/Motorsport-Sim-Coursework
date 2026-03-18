
namespace MotorsportSim.Career
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
            this.Tbx_saveName = new System.Windows.Forms.TextBox();
            this.Lbl_careerName = new System.Windows.Forms.Label();
            this.Lbl_lapCount = new System.Windows.Forms.Label();
            this.Cbx_lapCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_teamCount = new System.Windows.Forms.ComboBox();
            this.Lbl_managedTeam = new System.Windows.Forms.Label();
            this.Cbx_managedTeam = new System.Windows.Forms.ComboBox();
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
            // Tbx_saveName
            // 
            this.Tbx_saveName.Location = new System.Drawing.Point(670, 270);
            this.Tbx_saveName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tbx_saveName.Name = "Tbx_saveName";
            this.Tbx_saveName.Size = new System.Drawing.Size(300, 26);
            this.Tbx_saveName.TabIndex = 20;
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
            // Lbl_lapCount
            // 
            this.Lbl_lapCount.AutoSize = true;
            this.Lbl_lapCount.Location = new System.Drawing.Point(535, 320);
            this.Lbl_lapCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_lapCount.Name = "Lbl_lapCount";
            this.Lbl_lapCount.Size = new System.Drawing.Size(117, 20);
            this.Lbl_lapCount.TabIndex = 22;
            this.Lbl_lapCount.Text = "Laps per Race:";
            // 
            // Cbx_lapCount
            // 
            this.Cbx_lapCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_lapCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_lapCount.DropDownWidth = 200;
            this.Cbx_lapCount.FormattingEnabled = true;
            this.Cbx_lapCount.Location = new System.Drawing.Point(670, 320);
            this.Cbx_lapCount.Name = "Cbx_lapCount";
            this.Cbx_lapCount.Size = new System.Drawing.Size(300, 28);
            this.Cbx_lapCount.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Teams:";
            // 
            // Cbx_teamCount
            // 
            this.Cbx_teamCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_teamCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_teamCount.DropDownWidth = 200;
            this.Cbx_teamCount.FormattingEnabled = true;
            this.Cbx_teamCount.Location = new System.Drawing.Point(670, 370);
            this.Cbx_teamCount.Name = "Cbx_teamCount";
            this.Cbx_teamCount.Size = new System.Drawing.Size(300, 28);
            this.Cbx_teamCount.TabIndex = 25;
            // 
            // Lbl_managedTeam
            // 
            this.Lbl_managedTeam.AutoSize = true;
            this.Lbl_managedTeam.Location = new System.Drawing.Point(540, 420);
            this.Lbl_managedTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_managedTeam.Name = "Lbl_managedTeam";
            this.Lbl_managedTeam.Size = new System.Drawing.Size(115, 20);
            this.Lbl_managedTeam.TabIndex = 26;
            this.Lbl_managedTeam.Text = "Manage Team:";
            // 
            // Cbx_managedTeam
            // 
            this.Cbx_managedTeam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_managedTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_managedTeam.DropDownWidth = 200;
            this.Cbx_managedTeam.FormattingEnabled = true;
            this.Cbx_managedTeam.Location = new System.Drawing.Point(670, 420);
            this.Cbx_managedTeam.Name = "Cbx_managedTeam";
            this.Cbx_managedTeam.Size = new System.Drawing.Size(300, 28);
            this.Cbx_managedTeam.TabIndex = 27;
            // 
            // CareerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Cbx_managedTeam);
            this.Controls.Add(this.Lbl_managedTeam);
            this.Controls.Add(this.Cbx_teamCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbx_lapCount);
            this.Controls.Add(this.Lbl_lapCount);
            this.Controls.Add(this.Lbl_careerName);
            this.Controls.Add(this.Tbx_saveName);
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
        private System.Windows.Forms.TextBox Tbx_saveName;
        private System.Windows.Forms.Label Lbl_careerName;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Label Lbl_lapCount;
        private System.Windows.Forms.ComboBox Cbx_lapCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbx_teamCount;
        private System.Windows.Forms.Label Lbl_managedTeam;
        private System.Windows.Forms.ComboBox Cbx_managedTeam;
    }
}