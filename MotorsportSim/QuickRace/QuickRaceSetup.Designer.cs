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
            this.Cbx_lapCount = new System.Windows.Forms.ComboBox();
            this.Btn_startRace = new System.Windows.Forms.Button();
            this.Cbx_carCount = new System.Windows.Forms.ComboBox();
            this.Cbx_teamIndex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Cbx_lapCount
            // 
            this.Cbx_lapCount.FormattingEnabled = true;
            this.Cbx_lapCount.Location = new System.Drawing.Point(261, 176);
            this.Cbx_lapCount.Name = "Cbx_lapCount";
            this.Cbx_lapCount.Size = new System.Drawing.Size(121, 28);
            this.Cbx_lapCount.TabIndex = 0;
            // 
            // Btn_startRace
            // 
            this.Btn_startRace.Location = new System.Drawing.Point(261, 315);
            this.Btn_startRace.Name = "Btn_startRace";
            this.Btn_startRace.Size = new System.Drawing.Size(200, 150);
            this.Btn_startRace.TabIndex = 1;
            this.Btn_startRace.Text = "Start Race";
            this.Btn_startRace.UseVisualStyleBackColor = true;
            this.Btn_startRace.Click += new System.EventHandler(this.Btn_startRace_Click);
            // 
            // Cbx_carCount
            // 
            this.Cbx_carCount.FormattingEnabled = true;
            this.Cbx_carCount.Location = new System.Drawing.Point(407, 176);
            this.Cbx_carCount.Name = "Cbx_carCount";
            this.Cbx_carCount.Size = new System.Drawing.Size(121, 28);
            this.Cbx_carCount.TabIndex = 2;
            // 
            // Cbx_teamIndex
            // 
            this.Cbx_teamIndex.FormattingEnabled = true;
            this.Cbx_teamIndex.Location = new System.Drawing.Point(564, 176);
            this.Cbx_teamIndex.Name = "Cbx_teamIndex";
            this.Cbx_teamIndex.Size = new System.Drawing.Size(121, 28);
            this.Cbx_teamIndex.TabIndex = 3;
            // 
            // QuickRaceSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Cbx_teamIndex);
            this.Controls.Add(this.Cbx_carCount);
            this.Controls.Add(this.Btn_startRace);
            this.Controls.Add(this.Cbx_lapCount);
            this.Name = "QuickRaceSetup";
            this.Text = "QuickRaceSetup";
            this.Load += new System.EventHandler(this.QuickRaceSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_lapCount;
        private System.Windows.Forms.Button Btn_startRace;
        private System.Windows.Forms.ComboBox Cbx_carCount;
        private System.Windows.Forms.ComboBox Cbx_teamIndex;
    }
}