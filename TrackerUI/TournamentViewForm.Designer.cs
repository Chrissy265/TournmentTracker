namespace TrackerUI
{
    partial class TournamentViewForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.Team2ScoreBox = new System.Windows.Forms.TextBox();
            this.Team2Scorelabel = new System.Windows.Forms.Label();
            this.Team2Label = new System.Windows.Forms.Label();
            this.VSlabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Red;
            this.headerLabel.Location = new System.Drawing.Point(26, 32);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(214, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.Red;
            this.TournamentName.Location = new System.Drawing.Point(227, 32);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(150, 50);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            this.TournamentName.Click += new System.EventHandler(this.TournamentName_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.Red;
            this.RoundLabel.Location = new System.Drawing.Point(45, 126);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(94, 37);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(145, 125);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(232, 38);
            this.roundDropdown.TabIndex = 3;
            // 
            // UnplayedCheckbox
            // 
            this.UnplayedCheckbox.AutoSize = true;
            this.UnplayedCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedCheckbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedCheckbox.ForeColor = System.Drawing.Color.Red;
            this.UnplayedCheckbox.Location = new System.Drawing.Point(145, 182);
            this.UnplayedCheckbox.Name = "UnplayedCheckbox";
            this.UnplayedCheckbox.Size = new System.Drawing.Size(202, 41);
            this.UnplayedCheckbox.TabIndex = 4;
            this.UnplayedCheckbox.Text = "UnplayedOnly";
            this.UnplayedCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(35, 324);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(342, 272);
            this.matchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.Red;
            this.TeamOneName.Location = new System.Drawing.Point(498, 324);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(165, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(498, 385);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamOneScoreValue.Location = new System.Drawing.Point(648, 385);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // Team2ScoreBox
            // 
            this.Team2ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Team2ScoreBox.Location = new System.Drawing.Point(648, 566);
            this.Team2ScoreBox.Name = "Team2ScoreBox";
            this.Team2ScoreBox.Size = new System.Drawing.Size(100, 35);
            this.Team2ScoreBox.TabIndex = 11;
            // 
            // Team2Scorelabel
            // 
            this.Team2Scorelabel.AutoSize = true;
            this.Team2Scorelabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Scorelabel.ForeColor = System.Drawing.Color.Red;
            this.Team2Scorelabel.Location = new System.Drawing.Point(511, 562);
            this.Team2Scorelabel.Name = "Team2Scorelabel";
            this.Team2Scorelabel.Size = new System.Drawing.Size(82, 37);
            this.Team2Scorelabel.TabIndex = 10;
            this.Team2Scorelabel.Text = "Score";
            // 
            // Team2Label
            // 
            this.Team2Label.AutoSize = true;
            this.Team2Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Label.ForeColor = System.Drawing.Color.Red;
            this.Team2Label.Location = new System.Drawing.Point(498, 496);
            this.Team2Label.Name = "Team2Label";
            this.Team2Label.Size = new System.Drawing.Size(165, 37);
            this.Team2Label.TabIndex = 9;
            this.Team2Label.Text = "<team two>";
            // 
            // VSlabel
            // 
            this.VSlabel.AutoSize = true;
            this.VSlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSlabel.ForeColor = System.Drawing.Color.Red;
            this.VSlabel.Location = new System.Drawing.Point(593, 447);
            this.VSlabel.Name = "VSlabel";
            this.VSlabel.Size = new System.Drawing.Size(70, 37);
            this.VSlabel.TabIndex = 12;
            this.VSlabel.Text = "-VS-";
            this.VSlabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.Red;
            this.scoreButton.Location = new System.Drawing.Point(766, 472);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(148, 61);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 640);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.VSlabel);
            this.Controls.Add(this.Team2ScoreBox);
            this.Controls.Add(this.Team2Scorelabel);
            this.Controls.Add(this.Team2Label);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox UnplayedCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox Team2ScoreBox;
        private System.Windows.Forms.Label Team2Scorelabel;
        private System.Windows.Forms.Label Team2Label;
        private System.Windows.Forms.Label VSlabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

