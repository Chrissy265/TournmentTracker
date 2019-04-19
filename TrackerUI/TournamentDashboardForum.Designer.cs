namespace TrackerUI
{
    partial class TournamentDashboardForum
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
            this.CreatePrizeHeaderLabel = new System.Windows.Forms.Label();
            this.LoadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePrizeHeaderLabel
            // 
            this.CreatePrizeHeaderLabel.AutoSize = true;
            this.CreatePrizeHeaderLabel.BackColor = System.Drawing.Color.White;
            this.CreatePrizeHeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeHeaderLabel.ForeColor = System.Drawing.Color.Red;
            this.CreatePrizeHeaderLabel.Location = new System.Drawing.Point(145, 23);
            this.CreatePrizeHeaderLabel.Name = "CreatePrizeHeaderLabel";
            this.CreatePrizeHeaderLabel.Size = new System.Drawing.Size(385, 50);
            this.CreatePrizeHeaderLabel.TabIndex = 12;
            this.CreatePrizeHeaderLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropdown
            // 
            this.LoadExistingTournamentDropdown.FormattingEnabled = true;
            this.LoadExistingTournamentDropdown.Location = new System.Drawing.Point(172, 181);
            this.LoadExistingTournamentDropdown.Name = "LoadExistingTournamentDropdown";
            this.LoadExistingTournamentDropdown.Size = new System.Drawing.Size(331, 38);
            this.LoadExistingTournamentDropdown.TabIndex = 21;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.Red;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(176, 120);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(322, 37);
            this.LoadExistingTournamentLabel.TabIndex = 20;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.Red;
            this.LoadTournamentButton.Location = new System.Drawing.Point(233, 242);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(209, 43);
            this.LoadTournamentButton.TabIndex = 22;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.Red;
            this.CreateTournamentButton.Location = new System.Drawing.Point(190, 322);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(295, 79);
            this.CreateTournamentButton.TabIndex = 23;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 479);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentDropdown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.CreatePrizeHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForum";
            this.Text = "TournamentDashboardForum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreatePrizeHeaderLabel;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropdown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}