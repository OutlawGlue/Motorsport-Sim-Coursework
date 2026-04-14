namespace MotorsportSim.Career
{
    partial class CareerMenu
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
            this.Dgv_drivers = new System.Windows.Forms.DataGridView();
            this.Dgv_constructors = new System.Windows.Forms.DataGridView();
            this.Btn_nextRace = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_results = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_drivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_constructors)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_drivers
            // 
            this.Dgv_drivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_drivers.Location = new System.Drawing.Point(900, 50);
            this.Dgv_drivers.Name = "Dgv_drivers";
            this.Dgv_drivers.RowHeadersWidth = 62;
            this.Dgv_drivers.RowTemplate.Height = 28;
            this.Dgv_drivers.Size = new System.Drawing.Size(425, 300);
            this.Dgv_drivers.TabIndex = 0;
            // 
            // Dgv_constructors
            // 
            this.Dgv_constructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_constructors.Location = new System.Drawing.Point(900, 400);
            this.Dgv_constructors.Name = "Dgv_constructors";
            this.Dgv_constructors.RowHeadersWidth = 62;
            this.Dgv_constructors.RowTemplate.Height = 28;
            this.Dgv_constructors.Size = new System.Drawing.Size(425, 300);
            this.Dgv_constructors.TabIndex = 1;
            // 
            // Btn_nextRace
            // 
            this.Btn_nextRace.Location = new System.Drawing.Point(50, 50);
            this.Btn_nextRace.Name = "Btn_nextRace";
            this.Btn_nextRace.Size = new System.Drawing.Size(400, 300);
            this.Btn_nextRace.TabIndex = 2;
            this.Btn_nextRace.Text = "Next Race";
            this.Btn_nextRace.UseVisualStyleBackColor = true;
            this.Btn_nextRace.Click += new System.EventHandler(this.Btn_nextRace_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(50, 400);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(400, 300);
            this.Btn_back.TabIndex = 3;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_results
            // 
            this.Btn_results.Location = new System.Drawing.Point(475, 400);
            this.Btn_results.Name = "Btn_results";
            this.Btn_results.Size = new System.Drawing.Size(400, 300);
            this.Btn_results.TabIndex = 4;
            this.Btn_results.Text = "Results";
            this.Btn_results.UseVisualStyleBackColor = true;
            this.Btn_results.Click += new System.EventHandler(this.Btn_results_Click);
            // 
            // CareerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Btn_results);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_nextRace);
            this.Controls.Add(this.Dgv_constructors);
            this.Controls.Add(this.Dgv_drivers);
            this.Name = "CareerMenu";
            this.Text = "CareerMenu";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_drivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_constructors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_drivers;
        private System.Windows.Forms.DataGridView Dgv_constructors;
        private System.Windows.Forms.Button Btn_nextRace;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_results;
    }
}