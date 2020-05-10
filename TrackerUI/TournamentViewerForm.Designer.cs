namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListView();
            this.team1ScoreTextbox = new System.Windows.Forms.TextBox();
            this.team2ScoreTextbox = new System.Windows.Forms.TextBox();
            this.submitScoreButton = new System.Windows.Forms.Button();
            this.team1Name = new System.Windows.Forms.Label();
            this.team2Name = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(57, 47);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(322, 74);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentName.Location = new System.Drawing.Point(361, 47);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(223, 74);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            this.tournamentName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roundLabel.Location = new System.Drawing.Point(74, 135);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(112, 45);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            this.roundLabel.Click += new System.EventHandler(this.roundLabel_Click);
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(206, 133);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(357, 53);
            this.roundDropdown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(330, 202);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(254, 49);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // matchupListBox
            // 
            this.matchupListBox.HideSelection = false;
            this.matchupListBox.Location = new System.Drawing.Point(82, 268);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(502, 419);
            this.matchupListBox.TabIndex = 5;
            this.matchupListBox.UseCompatibleStateImageBehavior = false;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.matchupListBox_SelectedIndexChanged);
            // 
            // team1ScoreTextbox
            // 
            this.team1ScoreTextbox.Location = new System.Drawing.Point(726, 352);
            this.team1ScoreTextbox.Name = "team1ScoreTextbox";
            this.team1ScoreTextbox.Size = new System.Drawing.Size(288, 50);
            this.team1ScoreTextbox.TabIndex = 6;
            // 
            // team2ScoreTextbox
            // 
            this.team2ScoreTextbox.Location = new System.Drawing.Point(726, 483);
            this.team2ScoreTextbox.Name = "team2ScoreTextbox";
            this.team2ScoreTextbox.Size = new System.Drawing.Size(288, 50);
            this.team2ScoreTextbox.TabIndex = 7;
            // 
            // submitScoreButton
            // 
            this.submitScoreButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitScoreButton.Location = new System.Drawing.Point(697, 570);
            this.submitScoreButton.Name = "submitScoreButton";
            this.submitScoreButton.Size = new System.Drawing.Size(244, 61);
            this.submitScoreButton.TabIndex = 8;
            this.submitScoreButton.Text = "Submit Score";
            this.submitScoreButton.UseVisualStyleBackColor = true;
            this.submitScoreButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team1Name.Location = new System.Drawing.Point(621, 294);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(162, 45);
            this.team1Name.TabIndex = 9;
            this.team1Name.Text = "<team 1>";
            this.team1Name.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // team2Name
            // 
            this.team2Name.AutoSize = true;
            this.team2Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team2Name.Location = new System.Drawing.Point(621, 425);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(162, 45);
            this.team2Name.TabIndex = 10;
            this.team2Name.Text = "<team 2>";
            this.team2Name.Click += new System.EventHandler(this.team2Name_Click);
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team1ScoreLabel.Location = new System.Drawing.Point(621, 357);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(99, 45);
            this.team1ScoreLabel.TabIndex = 11;
            this.team1ScoreLabel.Text = "Score";
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team2ScoreLabel.Location = new System.Drawing.Point(621, 486);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(99, 45);
            this.team2ScoreLabel.TabIndex = 12;
            this.team2ScoreLabel.Text = "Score";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 733);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team2Name);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.submitScoreButton);
            this.Controls.Add(this.team2ScoreTextbox);
            this.Controls.Add(this.team1ScoreTextbox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListView matchupListBox;
        private System.Windows.Forms.TextBox team1ScoreTextbox;
        private System.Windows.Forms.TextBox team2ScoreTextbox;
        private System.Windows.Forms.Button submitScoreButton;
        private System.Windows.Forms.Label team1Name;
        private System.Windows.Forms.Label team2Name;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.Label team2ScoreLabel;
    }
}

