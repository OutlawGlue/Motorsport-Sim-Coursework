namespace MotorsportSim.QuickRace
{
    partial class QuickRaceSetup
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
            this.Btn_startRace = new System.Windows.Forms.Button();
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Lbl_teamCount = new System.Windows.Forms.Label();
            this.Lbl_teamIndex = new System.Windows.Forms.Label();
            this.Lbl_newQuickRace = new System.Windows.Forms.Label();
            this.Lbl_lapCount = new System.Windows.Forms.Label();
            this.Cbx_lapCount = new System.Windows.Forms.ComboBox();
            this.Cbx_teamCount = new System.Windows.Forms.ComboBox();
            this.Cbx_teamIndex = new System.Windows.Forms.ComboBox();
            this.Btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_startRace
            // 
            this.Btn_startRace.Location = new System.Drawing.Point(690, 460);
            this.Btn_startRace.Name = "Btn_startRace";
            this.Btn_startRace.Size = new System.Drawing.Size(200, 100);
            this.Btn_startRace.TabIndex = 1;
            this.Btn_startRace.Text = "Start Race";
            this.Btn_startRace.UseVisualStyleBackColor = true;
            this.Btn_startRace.Click += new System.EventHandler(this.Btn_startRace_Click);
            // 
            // Pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "Pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 20;
            // 
            // Lbl_teamCount
            // 
            this.Lbl_teamCount.AutoSize = true;
            this.Lbl_teamCount.Location = new System.Drawing.Point(465, 340);
            this.Lbl_teamCount.Name = "Lbl_teamCount";
            this.Lbl_teamCount.Size = new System.Drawing.Size(100, 20);
            this.Lbl_teamCount.TabIndex = 22;
            this.Lbl_teamCount.Text = "Team Count:";
            // 
            // Lbl_teamIndex
            // 
            this.Lbl_teamIndex.AutoSize = true;
            this.Lbl_teamIndex.Location = new System.Drawing.Point(450, 400);
            this.Lbl_teamIndex.Name = "Lbl_teamIndex";
            this.Lbl_teamIndex.Size = new System.Drawing.Size(115, 20);
            this.Lbl_teamIndex.TabIndex = 23;
            this.Lbl_teamIndex.Text = "Manage Team:";
            // 
            // Lbl_newQuickRace
            // 
            this.Lbl_newQuickRace.AutoSize = true;
            this.Lbl_newQuickRace.Location = new System.Drawing.Point(670, 240);
            this.Lbl_newQuickRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_newQuickRace.Name = "Lbl_newQuickRace";
            this.Lbl_newQuickRace.Size = new System.Drawing.Size(126, 20);
            this.Lbl_newQuickRace.TabIndex = 24;
            this.Lbl_newQuickRace.Text = "New Quick Race";
            // 
            // Lbl_lapCount
            // 
            this.Lbl_lapCount.AutoSize = true;
            this.Lbl_lapCount.Location = new System.Drawing.Point(450, 280);
            this.Lbl_lapCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_lapCount.Name = "Lbl_lapCount";
            this.Lbl_lapCount.Size = new System.Drawing.Size(117, 20);
            this.Lbl_lapCount.TabIndex = 25;
            this.Lbl_lapCount.Text = "Laps per Race:";
            // 
            // Cbx_lapCount
            // 
            this.Cbx_lapCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_lapCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_lapCount.DropDownWidth = 200;
            this.Cbx_lapCount.FormattingEnabled = true;
            this.Cbx_lapCount.Location = new System.Drawing.Point(590, 280);
            this.Cbx_lapCount.Name = "Cbx_lapCount";
            this.Cbx_lapCount.Size = new System.Drawing.Size(300, 28);
            this.Cbx_lapCount.TabIndex = 26;
            // 
            // Cbx_teamCount
            // 
            this.Cbx_teamCount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_teamCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_teamCount.DropDownWidth = 200;
            this.Cbx_teamCount.FormattingEnabled = true;
            this.Cbx_teamCount.Location = new System.Drawing.Point(590, 340);
            this.Cbx_teamCount.Name = "Cbx_teamCount";
            this.Cbx_teamCount.Size = new System.Drawing.Size(300, 28);
            this.Cbx_teamCount.TabIndex = 27;
            // 
            // Cbx_teamIndex
            // 
            this.Cbx_teamIndex.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cbx_teamIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_teamIndex.DropDownWidth = 200;
            this.Cbx_teamIndex.FormattingEnabled = true;
            this.Cbx_teamIndex.Location = new System.Drawing.Point(590, 400);
            this.Cbx_teamIndex.Name = "Cbx_teamIndex";
            this.Cbx_teamIndex.Size = new System.Drawing.Size(300, 28);
            this.Cbx_teamIndex.TabIndex = 28;
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(450, 460);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(200, 100);
            this.Btn_back.TabIndex = 29;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // QuickRaceSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Cbx_teamIndex);
            this.Controls.Add(this.Cbx_teamCount);
            this.Controls.Add(this.Cbx_lapCount);
            this.Controls.Add(this.Lbl_lapCount);
            this.Controls.Add(this.Lbl_newQuickRace);
            this.Controls.Add(this.Lbl_teamIndex);
            this.Controls.Add(this.Lbl_teamCount);
            this.Controls.Add(this.Pnl_top);
            this.Controls.Add(this.Btn_startRace);
            this.Name = "QuickRaceSetup";
            this.Text = "QuickRaceSetup";
            this.Load += new System.EventHandler(this.QuickRaceSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_startRace;
        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Label Lbl_teamCount;
        private System.Windows.Forms.Label Lbl_teamIndex;
        private System.Windows.Forms.Label Lbl_newQuickRace;
        private System.Windows.Forms.Label Lbl_lapCount;
        private System.Windows.Forms.ComboBox Cbx_lapCount;
        private System.Windows.Forms.ComboBox Cbx_teamCount;
        private System.Windows.Forms.ComboBox Cbx_teamIndex;
        private System.Windows.Forms.Button Btn_back;
    }
}