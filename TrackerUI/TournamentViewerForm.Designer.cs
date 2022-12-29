namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.cBoxRound = new System.Windows.Forms.ComboBox();
            this.chkUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.listMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTournament.Location = new System.Drawing.Point(40, 32);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(135, 30);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament: ";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRound.Location = new System.Drawing.Point(40, 84);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(73, 30);
            this.lblRound.TabIndex = 1;
            this.lblRound.Text = "Round";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTournamentName.Location = new System.Drawing.Point(181, 32);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(88, 30);
            this.lblTournamentName.TabIndex = 2;
            this.lblTournamentName.Text = "<none>";
            // 
            // cBoxRound
            // 
            this.cBoxRound.FormattingEnabled = true;
            this.cBoxRound.Location = new System.Drawing.Point(119, 76);
            this.cBoxRound.Name = "cBoxRound";
            this.cBoxRound.Size = new System.Drawing.Size(140, 38);
            this.cBoxRound.TabIndex = 3;
            // 
            // chkUnplayedOnly
            // 
            this.chkUnplayedOnly.AutoSize = true;
            this.chkUnplayedOnly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chkUnplayedOnly.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.chkUnplayedOnly.Location = new System.Drawing.Point(119, 131);
            this.chkUnplayedOnly.Name = "chkUnplayedOnly";
            this.chkUnplayedOnly.Size = new System.Drawing.Size(168, 34);
            this.chkUnplayedOnly.TabIndex = 4;
            this.chkUnplayedOnly.Text = "Unplayed Only";
            this.chkUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // listMatchup
            // 
            this.listMatchup.FormattingEnabled = true;
            this.listMatchup.ItemHeight = 30;
            this.listMatchup.Location = new System.Drawing.Point(40, 171);
            this.listMatchup.Name = "listMatchup";
            this.listMatchup.Size = new System.Drawing.Size(229, 214);
            this.listMatchup.TabIndex = 5;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamOne.Location = new System.Drawing.Point(328, 171);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(135, 30);
            this.lblTeamOne.TabIndex = 7;
            this.lblTeamOne.Text = "<Team One>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamOneScore.Location = new System.Drawing.Point(328, 213);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamOneScore.TabIndex = 8;
            this.lblTeamOneScore.Text = "Score";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(398, 208);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamOneScore.TabIndex = 9;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(398, 356);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamTwoScore.TabIndex = 12;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamTwoScore.Location = new System.Drawing.Point(328, 361);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(64, 30);
            this.lblTeamTwoScore.TabIndex = 11;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamTwo.Location = new System.Drawing.Point(328, 319);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(133, 30);
            this.lblTeamTwo.TabIndex = 10;
            this.lblTeamTwo.Text = "<Team Two>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblVS.Location = new System.Drawing.Point(377, 268);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(53, 30);
            this.lblVS.TabIndex = 13;
            this.lblVS.Text = "-VS-";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnScore.Location = new System.Drawing.Point(527, 261);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(124, 54);
            this.btnScore.TabIndex = 14;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 438);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.listMatchup);
            this.Controls.Add(this.chkUnplayedOnly);
            this.Controls.Add(this.cBoxRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTournament;
        private Label lblRound;
        private Label lblTournamentName;
        private ComboBox cBoxRound;
        private CheckBox chkUnplayedOnly;
        private ListBox listMatchup;
        private Label lblTeamOne;
        private Label lblTeamOneScore;
        private TextBox txtTeamOneScore;
        private TextBox txtTeamTwoScore;
        private Label lblTeamTwoScore;
        private Label lblTeamTwo;
        private Label lblVS;
        private Button btnScore;
    }
}