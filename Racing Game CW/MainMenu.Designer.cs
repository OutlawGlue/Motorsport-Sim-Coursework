
namespace Racing_Game_CW
{
    partial class MainMenu
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
            this.Cbx_loadSave = new System.Windows.Forms.ComboBox();
            this.Btn_settings = new System.Windows.Forms.Button();
            this.Btn_loadSave = new System.Windows.Forms.Button();
            this.Btn_newSave = new System.Windows.Forms.Button();
            this.Lbl_newSave = new System.Windows.Forms.Label();
            this.tbx_saveName = new System.Windows.Forms.TextBox();
            this.lbl_saveName = new System.Windows.Forms.Label();
            this.Pnl_sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 18;
            // 
            // pnl_sideBar
            // 
            this.Pnl_sideBar.Controls.Add(this.Cbx_loadSave);
            this.Pnl_sideBar.Controls.Add(this.Btn_settings);
            this.Pnl_sideBar.Controls.Add(this.Btn_loadSave);
            this.Pnl_sideBar.Location = new System.Drawing.Point(0, 135);
            this.Pnl_sideBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pnl_sideBar.Name = "pnl_sideBar";
            this.Pnl_sideBar.Size = new System.Drawing.Size(240, 650);
            this.Pnl_sideBar.TabIndex = 6;
            // 
            // cbx_loadSave
            // 
            this.Cbx_loadSave.FormattingEnabled = true;
            this.Cbx_loadSave.Location = new System.Drawing.Point(20, 120);
            this.Cbx_loadSave.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Cbx_loadSave.Name = "cbx_loadSave";
            this.Cbx_loadSave.Size = new System.Drawing.Size(200, 28);
            this.Cbx_loadSave.TabIndex = 19;
            // 
            // btn_settings
            // 
            this.Btn_settings.Location = new System.Drawing.Point(20, 560);
            this.Btn_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_settings.Name = "btn_settings";
            this.Btn_settings.Size = new System.Drawing.Size(200, 40);
            this.Btn_settings.TabIndex = 9;
            this.Btn_settings.Text = "Settings";
            this.Btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_loadSave
            // 
            this.Btn_loadSave.Location = new System.Drawing.Point(20, 80);
            this.Btn_loadSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.Btn_loadSave.Name = "btn_loadSave";
            this.Btn_loadSave.Size = new System.Drawing.Size(200, 40);
            this.Btn_loadSave.TabIndex = 8;
            this.Btn_loadSave.Text = "Load Selected Save";
            this.Btn_loadSave.UseVisualStyleBackColor = true;
            this.Btn_loadSave.Click += new System.EventHandler(this.Btn_loadSave_Click);
            // 
            // btn_newSave
            // 
            this.Btn_newSave.Location = new System.Drawing.Point(695, 650);
            this.Btn_newSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_newSave.Name = "btn_newSave";
            this.Btn_newSave.Size = new System.Drawing.Size(250, 50);
            this.Btn_newSave.TabIndex = 7;
            this.Btn_newSave.Text = "Create New Save";
            this.Btn_newSave.UseVisualStyleBackColor = true;
            this.Btn_newSave.Click += new System.EventHandler(this.Btn_newSave_Click);
            // 
            // lbl_newSave
            // 
            this.Lbl_newSave.AutoSize = true;
            this.Lbl_newSave.Location = new System.Drawing.Point(780, 230);
            this.Lbl_newSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_newSave.Name = "lbl_newSave";
            this.Lbl_newSave.Size = new System.Drawing.Size(80, 20);
            this.Lbl_newSave.TabIndex = 19;
            this.Lbl_newSave.Text = "New Save";
            // 
            // tbx_saveName
            // 
            this.tbx_saveName.Location = new System.Drawing.Point(670, 270);
            this.tbx_saveName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_saveName.Name = "tbx_saveName";
            this.tbx_saveName.Size = new System.Drawing.Size(300, 26);
            this.tbx_saveName.TabIndex = 20;
            // 
            // lbl_saveName
            // 
            this.lbl_saveName.AutoSize = true;
            this.lbl_saveName.Location = new System.Drawing.Point(550, 270);
            this.lbl_saveName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saveName.Name = "lbl_saveName";
            this.lbl_saveName.Size = new System.Drawing.Size(95, 20);
            this.lbl_saveName.TabIndex = 21;
            this.lbl_saveName.Text = "Save Name:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.lbl_saveName);
            this.Controls.Add(this.tbx_saveName);
            this.Controls.Add(this.Lbl_newSave);
            this.Controls.Add(this.Pnl_top);
            this.Controls.Add(this.Pnl_sideBar);
            this.Controls.Add(this.Btn_newSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Pnl_sideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Panel Pnl_sideBar;
        private System.Windows.Forms.Button Btn_newSave;
        private System.Windows.Forms.Button Btn_loadSave;
        private System.Windows.Forms.Button Btn_settings;
        private System.Windows.Forms.ComboBox Cbx_loadSave;
        private System.Windows.Forms.Label Lbl_newSave;
        private System.Windows.Forms.TextBox tbx_saveName;
        private System.Windows.Forms.Label lbl_saveName;
    }
}