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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.NewMembergroupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateMemberbutton = new System.Windows.Forms.Button();
            this.CellPhoneValueTextbox = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValueTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValueTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.TeamMembersListbox = new System.Windows.Forms.ListBox();
            this.RemoveSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.NewMembergroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamNameValue.Location = new System.Drawing.Point(12, 129);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(442, 22);
            this.TeamNameValue.TabIndex = 12;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.Red;
            this.TeamNameLabel.Location = new System.Drawing.Point(3, 76);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(205, 50);
            this.TeamNameLabel.TabIndex = 11;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.BackColor = System.Drawing.Color.White;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.CreateTeamLabel.Location = new System.Drawing.Point(3, 9);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(213, 50);
            this.CreateTeamLabel.TabIndex = 10;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.Color.Red;
            this.AddMemberButton.Location = new System.Drawing.Point(147, 278);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(209, 43);
            this.AddMemberButton.TabIndex = 18;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.CreateMemberbutton_Click);
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.SelectTeamLabel.Location = new System.Drawing.Point(109, 178);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(263, 37);
            this.SelectTeamLabel.TabIndex = 17;
            this.SelectTeamLabel.Text = "Select Team Member";
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(116, 239);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(280, 21);
            this.SelectTeamDropdown.TabIndex = 19;
            // 
            // NewMembergroupBox1
            // 
            this.NewMembergroupBox1.Controls.Add(this.CreateMemberbutton);
            this.NewMembergroupBox1.Controls.Add(this.CellPhoneValueTextbox);
            this.NewMembergroupBox1.Controls.Add(this.CellphoneLabel);
            this.NewMembergroupBox1.Controls.Add(this.EmailValue);
            this.NewMembergroupBox1.Controls.Add(this.EmailLabel);
            this.NewMembergroupBox1.Controls.Add(this.LastNameValueTextBox);
            this.NewMembergroupBox1.Controls.Add(this.LastNameLabel);
            this.NewMembergroupBox1.Controls.Add(this.FirstNameValueTextBox);
            this.NewMembergroupBox1.Controls.Add(this.FirstNameLabel);
            this.NewMembergroupBox1.Controls.Add(this.roundDropdown);
            this.NewMembergroupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMembergroupBox1.ForeColor = System.Drawing.Color.Red;
            this.NewMembergroupBox1.Location = new System.Drawing.Point(12, 348);
            this.NewMembergroupBox1.Name = "NewMembergroupBox1";
            this.NewMembergroupBox1.Size = new System.Drawing.Size(487, 278);
            this.NewMembergroupBox1.TabIndex = 20;
            this.NewMembergroupBox1.TabStop = false;
            this.NewMembergroupBox1.Text = " Add New Member";
            // 
            // CreateMemberbutton
            // 
            this.CreateMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberbutton.ForeColor = System.Drawing.Color.Red;
            this.CreateMemberbutton.Location = new System.Drawing.Point(135, 216);
            this.CreateMemberbutton.Name = "CreateMemberbutton";
            this.CreateMemberbutton.Size = new System.Drawing.Size(209, 43);
            this.CreateMemberbutton.TabIndex = 19;
            this.CreateMemberbutton.Text = "Create Member";
            this.CreateMemberbutton.UseVisualStyleBackColor = true;
            this.CreateMemberbutton.Click += new System.EventHandler(this.CreateMemberbutton_Click);
            // 
            // CellPhoneValueTextbox
            // 
            this.CellPhoneValueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CellPhoneValueTextbox.Location = new System.Drawing.Point(201, 150);
            this.CellPhoneValueTextbox.Name = "CellPhoneValueTextbox";
            this.CellPhoneValueTextbox.Size = new System.Drawing.Size(183, 35);
            this.CellPhoneValueTextbox.TabIndex = 17;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellphoneLabel.ForeColor = System.Drawing.Color.Red;
            this.CellphoneLabel.Location = new System.Drawing.Point(17, 150);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(151, 37);
            this.CellphoneLabel.TabIndex = 16;
            this.CellphoneLabel.Text = "Cell Phone ";
            // 
            // EmailValue
            // 
            this.EmailValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailValue.Location = new System.Drawing.Point(201, 113);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(183, 35);
            this.EmailValue.TabIndex = 15;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailLabel.Location = new System.Drawing.Point(17, 108);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 37);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValueTextBox
            // 
            this.LastNameValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameValueTextBox.Location = new System.Drawing.Point(201, 75);
            this.LastNameValueTextBox.Name = "LastNameValueTextBox";
            this.LastNameValueTextBox.Size = new System.Drawing.Size(183, 35);
            this.LastNameValueTextBox.TabIndex = 13;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Red;
            this.LastNameLabel.Location = new System.Drawing.Point(17, 71);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(142, 37);
            this.LastNameLabel.TabIndex = 12;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValueTextBox
            // 
            this.FirstNameValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameValueTextBox.Location = new System.Drawing.Point(201, 38);
            this.FirstNameValueTextBox.Name = "FirstNameValueTextBox";
            this.FirstNameValueTextBox.Size = new System.Drawing.Size(183, 35);
            this.FirstNameValueTextBox.TabIndex = 11;
            this.FirstNameValueTextBox.TextChanged += new System.EventHandler(this.TeamOneScoreValue_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Red;
            this.FirstNameLabel.Location = new System.Drawing.Point(15, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(144, 37);
            this.FirstNameLabel.TabIndex = 10;
            this.FirstNameLabel.Text = "First Name";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(-338, -226);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(232, 38);
            this.roundDropdown.TabIndex = 9;
            // 
            // TeamMembersListbox
            // 
            this.TeamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListbox.FormattingEnabled = true;
            this.TeamMembersListbox.Location = new System.Drawing.Point(570, 129);
            this.TeamMembersListbox.Name = "TeamMembersListbox";
            this.TeamMembersListbox.Size = new System.Drawing.Size(367, 509);
            this.TeamMembersListbox.TabIndex = 21;
            // 
            // RemoveSelectedMemberButton
            // 
            this.RemoveSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.RemoveSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedMemberButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveSelectedMemberButton.Location = new System.Drawing.Point(967, 278);
            this.RemoveSelectedMemberButton.Name = "RemoveSelectedMemberButton";
            this.RemoveSelectedMemberButton.Size = new System.Drawing.Size(148, 86);
            this.RemoveSelectedMemberButton.TabIndex = 22;
            this.RemoveSelectedMemberButton.Text = "Remove Selected";
            this.RemoveSelectedMemberButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedMemberButton.Click += new System.EventHandler(this.RemoveSelectedMemberButton_Click);
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.Red;
            this.CreateTournamentButton.Location = new System.Drawing.Point(428, 677);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(220, 66);
            this.CreateTournamentButton.TabIndex = 23;
            this.CreateTournamentButton.Text = "Create Team";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 755);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.RemoveSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListbox);
            this.Controls.Add(this.NewMembergroupBox1);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.NewMembergroupBox1.ResumeLayout(false);
            this.NewMembergroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.GroupBox NewMembergroupBox1;
        private System.Windows.Forms.TextBox FirstNameValueTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.TextBox LastNameValueTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button CreateMemberbutton;
        private System.Windows.Forms.TextBox CellPhoneValueTextbox;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.ListBox TeamMembersListbox;
        private System.Windows.Forms.Button RemoveSelectedMemberButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}