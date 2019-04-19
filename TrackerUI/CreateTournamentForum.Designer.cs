namespace TrackerUI
{
    partial class CreateTournamentForum
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
            this.CreateTournament = new System.Windows.Forms.Label();
            this.TournamentNameLabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.EntrryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.TeamDropdown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateTeamLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TeamPlayersLabel = new System.Windows.Forms.Label();
            this.DelectedSelectedPlayersButton = new System.Windows.Forms.Button();
            this.PrizesDeletebutton = new System.Windows.Forms.Button();
            this.PrizesLabel = new System.Windows.Forms.Label();
            this.PrizesListbox = new System.Windows.Forms.ListBox();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTournament
            // 
            this.CreateTournament.AutoSize = true;
            this.CreateTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournament.ForeColor = System.Drawing.Color.Red;
            this.CreateTournament.Location = new System.Drawing.Point(28, 28);
            this.CreateTournament.Name = "CreateTournament";
            this.CreateTournament.Size = new System.Drawing.Size(317, 50);
            this.CreateTournament.TabIndex = 1;
            this.CreateTournament.Text = "Create Tournament";
            // 
            // TournamentNameLabel
            // 
            this.TournamentNameLabel.AutoSize = true;
            this.TournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNameLabel.ForeColor = System.Drawing.Color.Red;
            this.TournamentNameLabel.Location = new System.Drawing.Point(28, 143);
            this.TournamentNameLabel.Name = "TournamentNameLabel";
            this.TournamentNameLabel.Size = new System.Drawing.Size(309, 50);
            this.TournamentNameLabel.TabIndex = 2;
            this.TournamentNameLabel.Text = "Tournament Name";
            this.TournamentNameLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentNameValue.Location = new System.Drawing.Point(37, 223);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(280, 20);
            this.TournamentNameValue.TabIndex = 9;
            // 
            // EntrryFeeValue
            // 
            this.EntrryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntrryFeeValue.Location = new System.Drawing.Point(218, 328);
            this.EntrryFeeValue.Name = "EntrryFeeValue";
            this.EntrryFeeValue.Size = new System.Drawing.Size(127, 20);
            this.EntrryFeeValue.TabIndex = 11;
            this.EntrryFeeValue.Text = "0";
            this.EntrryFeeValue.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.Red;
            this.EntryFeeLabel.Location = new System.Drawing.Point(28, 301);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(168, 50);
            this.EntryFeeLabel.TabIndex = 10;
            this.EntryFeeLabel.Text = "Entry Fee";
            this.EntryFeeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // TeamDropdown
            // 
            this.TeamDropdown.FormattingEnabled = true;
            this.TeamDropdown.Location = new System.Drawing.Point(50, 454);
            this.TeamDropdown.Name = "TeamDropdown";
            this.TeamDropdown.Size = new System.Drawing.Size(267, 21);
            this.TeamDropdown.TabIndex = 13;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.SelectTeamLabel.Location = new System.Drawing.Point(43, 414);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.SelectTeamLabel.TabIndex = 12;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateTeamLinkLabel
            // 
            this.CreateTeamLinkLabel.AutoSize = true;
            this.CreateTeamLinkLabel.Location = new System.Drawing.Point(224, 433);
            this.CreateTeamLinkLabel.Name = "CreateTeamLinkLabel";
            this.CreateTeamLinkLabel.Size = new System.Drawing.Size(93, 13);
            this.CreateTeamLinkLabel.TabIndex = 15;
            this.CreateTeamLinkLabel.TabStop = true;
            this.CreateTeamLinkLabel.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.Red;
            this.AddTeamButton.Location = new System.Drawing.Point(80, 481);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(209, 43);
            this.AddTeamButton.TabIndex = 16;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.Red;
            this.CreatePrizeButton.Location = new System.Drawing.Point(80, 552);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(209, 43);
            this.CreatePrizeButton.TabIndex = 17;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(430, 184);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(342, 158);
            this.tournamentPlayersListBox.TabIndex = 18;
            // 
            // TeamPlayersLabel
            // 
            this.TeamPlayersLabel.AutoSize = true;
            this.TeamPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamPlayersLabel.ForeColor = System.Drawing.Color.Red;
            this.TeamPlayersLabel.Location = new System.Drawing.Point(430, 121);
            this.TeamPlayersLabel.Name = "TeamPlayersLabel";
            this.TeamPlayersLabel.Size = new System.Drawing.Size(238, 50);
            this.TeamPlayersLabel.TabIndex = 19;
            this.TeamPlayersLabel.Text = "Teams/Players";
            // 
            // DelectedSelectedPlayersButton
            // 
            this.DelectedSelectedPlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DelectedSelectedPlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DelectedSelectedPlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DelectedSelectedPlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelectedSelectedPlayersButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelectedSelectedPlayersButton.ForeColor = System.Drawing.Color.Red;
            this.DelectedSelectedPlayersButton.Location = new System.Drawing.Point(875, 223);
            this.DelectedSelectedPlayersButton.Name = "DelectedSelectedPlayersButton";
            this.DelectedSelectedPlayersButton.Size = new System.Drawing.Size(148, 86);
            this.DelectedSelectedPlayersButton.TabIndex = 20;
            this.DelectedSelectedPlayersButton.Text = "Delete Selected";
            this.DelectedSelectedPlayersButton.UseVisualStyleBackColor = true;
            // 
            // PrizesDeletebutton
            // 
            this.PrizesDeletebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PrizesDeletebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PrizesDeletebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PrizesDeletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrizesDeletebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesDeletebutton.ForeColor = System.Drawing.Color.Red;
            this.PrizesDeletebutton.Location = new System.Drawing.Point(875, 481);
            this.PrizesDeletebutton.Name = "PrizesDeletebutton";
            this.PrizesDeletebutton.Size = new System.Drawing.Size(148, 89);
            this.PrizesDeletebutton.TabIndex = 23;
            this.PrizesDeletebutton.Text = "Delete Selected";
            this.PrizesDeletebutton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            this.PrizesLabel.AutoSize = true;
            this.PrizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizesLabel.ForeColor = System.Drawing.Color.Red;
            this.PrizesLabel.Location = new System.Drawing.Point(430, 374);
            this.PrizesLabel.Name = "PrizesLabel";
            this.PrizesLabel.Size = new System.Drawing.Size(238, 50);
            this.PrizesLabel.TabIndex = 22;
            this.PrizesLabel.Text = "Teams/Players";
            // 
            // PrizesListbox
            // 
            this.PrizesListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListbox.FormattingEnabled = true;
            this.PrizesListbox.Location = new System.Drawing.Point(430, 437);
            this.PrizesListbox.Name = "PrizesListbox";
            this.PrizesListbox.Size = new System.Drawing.Size(342, 158);
            this.PrizesListbox.TabIndex = 21;
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentbutton.ForeColor = System.Drawing.Color.Red;
            this.CreateTournamentbutton.Location = new System.Drawing.Point(430, 625);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(238, 64);
            this.CreateTournamentbutton.TabIndex = 24;
            this.CreateTournamentbutton.Text = "Create Tournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentLabel.ForeColor = System.Drawing.Color.Red;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(20, 41);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(317, 50);
            this.CreateTournamentLabel.TabIndex = 1;
            this.CreateTournamentLabel.Text = "Create Tournament";
            // 
            // CreateTournamentForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 701);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.PrizesDeletebutton);
            this.Controls.Add(this.PrizesLabel);
            this.Controls.Add(this.PrizesListbox);
            this.Controls.Add(this.DelectedSelectedPlayersButton);
            this.Controls.Add(this.TeamPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateTeamLinkLabel);
            this.Controls.Add(this.TeamDropdown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntrryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.TournamentNameLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Controls.Add(this.CreateTournament);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "CreateTournamentForum";
            this.Text = "create new";
            this.Load += new System.EventHandler(this.CreateTournamentForum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournament;
        private System.Windows.Forms.Label TournamentNameLabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.TextBox EntrryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.Windows.Forms.ComboBox TeamDropdown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateTeamLinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label TeamPlayersLabel;
        private System.Windows.Forms.Button DelectedSelectedPlayersButton;
        private System.Windows.Forms.Button PrizesDeletebutton;
        private System.Windows.Forms.Label PrizesLabel;
        private System.Windows.Forms.ListBox PrizesListbox;
        private System.Windows.Forms.Button CreateTournamentbutton;
        private System.Windows.Forms.Label CreateTournamentLabel;
    }
}