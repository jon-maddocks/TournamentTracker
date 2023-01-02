namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cboxSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.linkCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lbTournamentTeams = new System.Windows.Forms.ListBox();
            this.lblTeamPlayers = new System.Windows.Forms.Label();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrizes = new System.Windows.Forms.ListBox();
            this.btnRemovePrize = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateTournament.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCreateTournament.Location = new System.Drawing.Point(25, 23);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(219, 32);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(51, 96);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(333, 35);
            this.txtTournamentName.TabIndex = 11;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTournamentName.Location = new System.Drawing.Point(47, 63);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(186, 30);
            this.lblTournamentName.TabIndex = 10;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(151, 160);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(133, 35);
            this.txtEntryFee.TabIndex = 13;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEntryFee.Location = new System.Drawing.Point(47, 163);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(98, 30);
            this.lblEntryFee.TabIndex = 12;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // cboxSelectTeam
            // 
            this.cboxSelectTeam.FormattingEnabled = true;
            this.cboxSelectTeam.Location = new System.Drawing.Point(51, 266);
            this.cboxSelectTeam.Name = "cboxSelectTeam";
            this.cboxSelectTeam.Size = new System.Drawing.Size(333, 38);
            this.cboxSelectTeam.TabIndex = 15;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSelectTeam.Location = new System.Drawing.Point(51, 233);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(123, 30);
            this.lblSelectTeam.TabIndex = 14;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // linkCreateNewTeam
            // 
            this.linkCreateNewTeam.AutoSize = true;
            this.linkCreateNewTeam.Location = new System.Drawing.Point(279, 233);
            this.linkCreateNewTeam.Name = "linkCreateNewTeam";
            this.linkCreateNewTeam.Size = new System.Drawing.Size(121, 30);
            this.linkCreateNewTeam.TabIndex = 16;
            this.linkCreateNewTeam.TabStop = true;
            this.linkCreateNewTeam.Text = "Create New";
            this.linkCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateNewTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddTeam.Location = new System.Drawing.Point(120, 324);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(200, 54);
            this.btnAddTeam.TabIndex = 17;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreatePrize.Location = new System.Drawing.Point(120, 398);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(200, 54);
            this.btnCreatePrize.TabIndex = 18;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // lbTournamentTeams
            // 
            this.lbTournamentTeams.FormattingEnabled = true;
            this.lbTournamentTeams.ItemHeight = 30;
            this.lbTournamentTeams.Location = new System.Drawing.Point(468, 79);
            this.lbTournamentTeams.Name = "lbTournamentTeams";
            this.lbTournamentTeams.Size = new System.Drawing.Size(322, 154);
            this.lbTournamentTeams.TabIndex = 19;
            // 
            // lblTeamPlayers
            // 
            this.lblTeamPlayers.AutoSize = true;
            this.lblTeamPlayers.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamPlayers.Location = new System.Drawing.Point(468, 46);
            this.lblTeamPlayers.Name = "lblTeamPlayers";
            this.lblTeamPlayers.Size = new System.Drawing.Size(144, 30);
            this.lblTeamPlayers.TabIndex = 20;
            this.lblTeamPlayers.Text = "Teams/Players";
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRemoveTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemoveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRemoveTeam.Location = new System.Drawing.Point(802, 139);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(130, 71);
            this.btnRemoveTeam.TabIndex = 21;
            this.btnRemoveTeam.Text = "Remove Selected";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(468, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Prizes";
            // 
            // lbPrizes
            // 
            this.lbPrizes.FormattingEnabled = true;
            this.lbPrizes.ItemHeight = 30;
            this.lbPrizes.Location = new System.Drawing.Point(468, 324);
            this.lbPrizes.Name = "lbPrizes";
            this.lbPrizes.Size = new System.Drawing.Size(322, 154);
            this.lbPrizes.TabIndex = 22;
            // 
            // btnRemovePrize
            // 
            this.btnRemovePrize.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRemovePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemovePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRemovePrize.Location = new System.Drawing.Point(802, 375);
            this.btnRemovePrize.Name = "btnRemovePrize";
            this.btnRemovePrize.Size = new System.Drawing.Size(130, 77);
            this.btnRemovePrize.TabIndex = 24;
            this.btnRemovePrize.Text = "Remove Selected";
            this.btnRemovePrize.UseVisualStyleBackColor = true;
            this.btnRemovePrize.Click += new System.EventHandler(this.btnRemovePrize_Click);
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateTournament.Location = new System.Drawing.Point(365, 510);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(200, 54);
            this.btnCreateTournament.TabIndex = 26;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(944, 597);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemovePrize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrizes);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.lblTeamPlayers);
            this.Controls.Add(this.lbTournamentTeams);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.linkCreateNewTeam);
            this.Controls.Add(this.cboxSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCreateTournament;
        private TextBox txtTournamentName;
        private Label lblTournamentName;
        private TextBox txtEntryFee;
        private Label lblEntryFee;
        private ComboBox cboxSelectTeam;
        private Label lblSelectTeam;
        private LinkLabel linkCreateNewTeam;
        private Button btnAddTeam;
        private Button btnCreatePrize;
        private ListBox lbTournamentTeams;
        private Label lblTeamPlayers;
        private Button btnRemoveTeam;
        private Label label1;
        private ListBox lbPrizes;
        private Button btnRemovePrize;
        private Button btnCreateTournament;
    }
}