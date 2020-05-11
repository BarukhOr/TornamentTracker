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
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamMemberLabel = new System.Windows.Forms.Label();
            this.teamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneTextBox = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.removeMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.teamMemberListBox = new System.Windows.Forms.ListBox();
            this.addNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(56, 114);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(186, 45);
            this.teamNameLabel.TabIndex = 0;
            this.teamNameLabel.Text = "Team Name:";
            this.teamNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(60, 164);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(519, 50);
            this.teamNameTextBox.TabIndex = 1;
            // 
            // teamMemberLabel
            // 
            this.teamMemberLabel.AutoSize = true;
            this.teamMemberLabel.Location = new System.Drawing.Point(56, 249);
            this.teamMemberLabel.Name = "teamMemberLabel";
            this.teamMemberLabel.Size = new System.Drawing.Size(212, 45);
            this.teamMemberLabel.TabIndex = 2;
            this.teamMemberLabel.Text = "Team Member";
            // 
            // teamMemberDropdown
            // 
            this.teamMemberDropdown.FormattingEnabled = true;
            this.teamMemberDropdown.Location = new System.Drawing.Point(64, 308);
            this.teamMemberDropdown.Name = "teamMemberDropdown";
            this.teamMemberDropdown.Size = new System.Drawing.Size(515, 53);
            this.teamMemberDropdown.TabIndex = 3;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(243, 406);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(217, 55);
            this.addMemberButton.TabIndex = 4;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(36, 66);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(165, 45);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(261, 63);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(249, 50);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(261, 146);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(249, 50);
            this.lastNameTextBox.TabIndex = 9;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(38, 151);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(163, 45);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(261, 222);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(249, 50);
            this.emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(38, 225);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(92, 45);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // cellphoneTextBox
            // 
            this.cellphoneTextBox.Location = new System.Drawing.Point(261, 297);
            this.cellphoneTextBox.Name = "cellphoneTextBox";
            this.cellphoneTextBox.Size = new System.Drawing.Size(249, 50);
            this.cellphoneTextBox.TabIndex = 13;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Location = new System.Drawing.Point(38, 300);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(156, 45);
            this.cellphoneLabel.TabIndex = 12;
            this.cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(101, 372);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(364, 59);
            this.createMemberButton.TabIndex = 14;
            this.createMemberButton.Text = "Create New Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // removeMemberButton
            // 
            this.removeMemberButton.Location = new System.Drawing.Point(728, 944);
            this.removeMemberButton.Name = "removeMemberButton";
            this.removeMemberButton.Size = new System.Drawing.Size(365, 59);
            this.removeMemberButton.TabIndex = 16;
            this.removeMemberButton.Text = "Remove Selected Button";
            this.removeMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(499, 1073);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(217, 59);
            this.createTeamButton.TabIndex = 17;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(51)))));
            this.headerLabel.Location = new System.Drawing.Point(48, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(389, 68);
            this.headerLabel.TabIndex = 18;
            this.headerLabel.Text = "Create Team";
            // 
            // addNewMemberGroupBox
            // 
            this.addNewMemberGroupBox.Controls.Add(this.firstNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMemberGroupBox.Controls.Add(this.createMemberButton);
            this.addNewMemberGroupBox.Controls.Add(this.emailLabel);
            this.addNewMemberGroupBox.Controls.Add(this.cellphoneTextBox);
            this.addNewMemberGroupBox.Controls.Add(this.emailTextBox);
            this.addNewMemberGroupBox.Location = new System.Drawing.Point(31, 547);
            this.addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            this.addNewMemberGroupBox.Size = new System.Drawing.Size(577, 456);
            this.addNewMemberGroupBox.TabIndex = 19;
            this.addNewMemberGroupBox.TabStop = false;
            this.addNewMemberGroupBox.Text = "Add New Member";
            this.addNewMemberGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // teamMemberListBox
            // 
            this.teamMemberListBox.FormattingEnabled = true;
            this.teamMemberListBox.ItemHeight = 45;
            this.teamMemberListBox.Location = new System.Drawing.Point(639, 114);
            this.teamMemberListBox.Name = "teamMemberListBox";
            this.teamMemberListBox.Size = new System.Drawing.Size(519, 814);
            this.teamMemberListBox.TabIndex = 20;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 1169);
            this.Controls.Add(this.teamMemberListBox);
            this.Controls.Add(this.addNewMemberGroupBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.teamMemberDropdown);
            this.Controls.Add(this.teamMemberLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.teamNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.Load += new System.EventHandler(this.CreateTeamForm_Load);
            this.addNewMemberGroupBox.ResumeLayout(false);
            this.addNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.Label teamMemberLabel;
        private System.Windows.Forms.ComboBox teamMemberDropdown;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox cellphoneTextBox;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Button removeMemberButton;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox addNewMemberGroupBox;
        private System.Windows.Forms.ListBox teamMemberListBox;
    }
}