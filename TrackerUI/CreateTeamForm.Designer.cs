namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cboxSelectMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.grpAddNewMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.listTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.grpAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(41, 126);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(360, 35);
            this.txtTeamName.TabIndex = 13;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTeamName.Location = new System.Drawing.Point(37, 93);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(124, 30);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Create Team";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddMember.Location = new System.Drawing.Point(110, 298);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(200, 54);
            this.btnAddMember.TabIndex = 20;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // cboxSelectMember
            // 
            this.cboxSelectMember.FormattingEnabled = true;
            this.cboxSelectMember.Location = new System.Drawing.Point(41, 240);
            this.cboxSelectMember.Name = "cboxSelectMember";
            this.cboxSelectMember.Size = new System.Drawing.Size(360, 38);
            this.cboxSelectMember.TabIndex = 19;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSelectTeamMember.Location = new System.Drawing.Point(41, 207);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(207, 30);
            this.lblSelectTeamMember.TabIndex = 18;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // grpAddNewMember
            // 
            this.grpAddNewMember.Controls.Add(this.btnCreateMember);
            this.grpAddNewMember.Controls.Add(this.txtCellPhone);
            this.grpAddNewMember.Controls.Add(this.lblPhone);
            this.grpAddNewMember.Controls.Add(this.txtEmail);
            this.grpAddNewMember.Controls.Add(this.lblEmail);
            this.grpAddNewMember.Controls.Add(this.txtLastName);
            this.grpAddNewMember.Controls.Add(this.lblLastName);
            this.grpAddNewMember.Controls.Add(this.txtFirstName);
            this.grpAddNewMember.Controls.Add(this.lblFirstName);
            this.grpAddNewMember.Location = new System.Drawing.Point(37, 385);
            this.grpAddNewMember.Name = "grpAddNewMember";
            this.grpAddNewMember.Size = new System.Drawing.Size(364, 319);
            this.grpAddNewMember.TabIndex = 21;
            this.grpAddNewMember.TabStop = false;
            this.grpAddNewMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateMember.Location = new System.Drawing.Point(97, 255);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(169, 46);
            this.btnCreateMember.TabIndex = 22;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(132, 199);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(213, 35);
            this.txtCellPhone.TabIndex = 21;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblPhone.Location = new System.Drawing.Point(13, 202);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(106, 30);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Cellphone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(213, 35);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEmail.Location = new System.Drawing.Point(13, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 30);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(132, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 35);
            this.txtLastName.TabIndex = 17;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLastName.Location = new System.Drawing.Point(13, 105);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 30);
            this.lblLastName.TabIndex = 16;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(132, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 35);
            this.txtFirstName.TabIndex = 15;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFirstName.Location = new System.Drawing.Point(13, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 30);
            this.lblFirstName.TabIndex = 14;
            this.lblFirstName.Text = "First Name";
            // 
            // listTeamMembers
            // 
            this.listTeamMembers.FormattingEnabled = true;
            this.listTeamMembers.ItemHeight = 30;
            this.listTeamMembers.Location = new System.Drawing.Point(428, 126);
            this.listTeamMembers.Name = "listTeamMembers";
            this.listTeamMembers.Size = new System.Drawing.Size(322, 574);
            this.listTeamMembers.TabIndex = 23;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeleteMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMember.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDeleteMember.Location = new System.Drawing.Point(756, 385);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(129, 90);
            this.btnDeleteMember.TabIndex = 24;
            this.btnDeleteMember.Text = "Deleted Selected";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCreateTeam.Location = new System.Drawing.Point(338, 741);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(270, 69);
            this.btnCreateTeam.TabIndex = 25;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(918, 833);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.listTeamMembers);
            this.Controls.Add(this.grpAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cboxSelectMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.grpAddNewMember.ResumeLayout(false);
            this.grpAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTeamName;
        private Label lblTeamName;
        private Label label1;
        private Button btnAddMember;
        private ComboBox cboxSelectMember;
        private Label lblSelectTeamMember;
        private GroupBox grpAddNewMember;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnCreateMember;
        private TextBox txtCellPhone;
        private Label lblPhone;
        private TextBox txtEmail;
        private Label lblEmail;
        private ListBox listTeamMembers;
        private Button btnDeleteMember;
        private Button btnCreateTeam;
    }
}