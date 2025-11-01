
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_sideBar = new System.Windows.Forms.Panel();
            this.cbx_loadSave = new System.Windows.Forms.ComboBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_newSave = new System.Windows.Forms.Button();
            this.btn_loadSave = new System.Windows.Forms.Button();
            this.lbl_newSave = new System.Windows.Forms.Label();
            this.tbx_saveName = new System.Windows.Forms.TextBox();
            this.lbl_saveName = new System.Windows.Forms.Label();
            this.pnl_sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(900, 88);
            this.pnl_top.TabIndex = 18;
            // 
            // pnl_sideBar
            // 
            this.pnl_sideBar.Controls.Add(this.cbx_loadSave);
            this.pnl_sideBar.Controls.Add(this.btn_settings);
            this.pnl_sideBar.Controls.Add(this.btn_loadSave);
            this.pnl_sideBar.Location = new System.Drawing.Point(0, 88);
            this.pnl_sideBar.Name = "pnl_sideBar";
            this.pnl_sideBar.Size = new System.Drawing.Size(175, 484);
            this.pnl_sideBar.TabIndex = 6;
            // 
            // cbx_loadSave
            // 
            this.cbx_loadSave.FormattingEnabled = true;
            this.cbx_loadSave.Location = new System.Drawing.Point(12, 78);
            this.cbx_loadSave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.cbx_loadSave.Name = "cbx_loadSave";
            this.cbx_loadSave.Size = new System.Drawing.Size(150, 21);
            this.cbx_loadSave.TabIndex = 19;
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(12, 364);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(150, 26);
            this.btn_settings.TabIndex = 9;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // btn_newSave
            // 
            this.btn_newSave.Location = new System.Drawing.Point(450, 430);
            this.btn_newSave.Name = "btn_newSave";
            this.btn_newSave.Size = new System.Drawing.Size(150, 26);
            this.btn_newSave.TabIndex = 7;
            this.btn_newSave.Text = "Create New Save";
            this.btn_newSave.UseVisualStyleBackColor = true;
            this.btn_newSave.Click += new System.EventHandler(this.btn_newSave_Click);
            // 
            // btn_loadSave
            // 
            this.btn_loadSave.Location = new System.Drawing.Point(12, 52);
            this.btn_loadSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_loadSave.Name = "btn_loadSave";
            this.btn_loadSave.Size = new System.Drawing.Size(150, 26);
            this.btn_loadSave.TabIndex = 8;
            this.btn_loadSave.Text = "Load Selected Save";
            this.btn_loadSave.UseVisualStyleBackColor = true;
            this.btn_loadSave.Click += new System.EventHandler(this.btn_loadSave_Click);
            // 
            // lbl_newSave
            // 
            this.lbl_newSave.AutoSize = true;
            this.lbl_newSave.Location = new System.Drawing.Point(450, 150);
            this.lbl_newSave.Name = "lbl_newSave";
            this.lbl_newSave.Size = new System.Drawing.Size(57, 13);
            this.lbl_newSave.TabIndex = 19;
            this.lbl_newSave.Text = "New Save";
            // 
            // tbx_saveName
            // 
            this.tbx_saveName.Location = new System.Drawing.Point(420, 180);
            this.tbx_saveName.Name = "tbx_saveName";
            this.tbx_saveName.Size = new System.Drawing.Size(200, 20);
            this.tbx_saveName.TabIndex = 20;
            // 
            // lbl_saveName
            // 
            this.lbl_saveName.AutoSize = true;
            this.lbl_saveName.Location = new System.Drawing.Point(320, 180);
            this.lbl_saveName.Name = "lbl_saveName";
            this.lbl_saveName.Size = new System.Drawing.Size(66, 13);
            this.lbl_saveName.TabIndex = 21;
            this.lbl_saveName.Text = "Save Name:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 483);
            this.Controls.Add(this.lbl_saveName);
            this.Controls.Add(this.tbx_saveName);
            this.Controls.Add(this.lbl_newSave);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_sideBar);
            this.Controls.Add(this.btn_newSave);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.pnl_sideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_sideBar;
        private System.Windows.Forms.Button btn_newSave;
        private System.Windows.Forms.Button btn_loadSave;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.ComboBox cbx_loadSave;
        private System.Windows.Forms.Label lbl_newSave;
        private System.Windows.Forms.TextBox tbx_saveName;
        private System.Windows.Forms.Label lbl_saveName;
    }
}