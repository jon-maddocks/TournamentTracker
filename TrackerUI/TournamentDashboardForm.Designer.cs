namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblLoadExisting = new System.Windows.Forms.Label();
            this.cboxLoadTournament = new System.Windows.Forms.ComboBox();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDashboard.Location = new System.Drawing.Point(163, 27);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(265, 32);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Tournament Dashboard";
            // 
            // lblLoadExisting
            // 
            this.lblLoadExisting.AutoSize = true;
            this.lblLoadExisting.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLoadExisting.Location = new System.Drawing.Point(169, 84);
            this.lblLoadExisting.Name = "lblLoadExisting";
            this.lblLoadExisting.Size = new System.Drawing.Size(252, 30);
            this.lblLoadExisting.TabIndex = 12;
            this.lblLoadExisting.Text = "Load Existing Tournament";
            // 
            // cboxLoadTournament
            // 
            this.cboxLoadTournament.FormattingEnabled = true;
            this.cboxLoadTournament.Location = new System.Drawing.Point(129, 117);
            this.cboxLoadTournament.Name = "cboxLoadTournament";
            this.cboxLoadTournament.Size = new System.Drawing.Size(333, 38);
            this.cboxLoadTournament.TabIndex = 16;
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLoadTournament.Location = new System.Drawing.Point(195, 169);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(200, 54);
            this.btnLoadTournament.TabIndex = 19;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateTournament.Location = new System.Drawing.Point(163, 241);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(267, 100);
            this.btnCreateTournament.TabIndex = 20;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(591, 380);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.cboxLoadTournament);
            this.Controls.Add(this.lblLoadExisting);
            this.Controls.Add(this.lblDashboard);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDashboard;
        private Label lblLoadExisting;
        private ComboBox cboxLoadTournament;
        private Button btnLoadTournament;
        private Button btnCreateTournament;
    }
}