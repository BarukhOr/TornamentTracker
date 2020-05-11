using System;

namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.placeNumerLabel = new System.Windows.Forms.Label();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.placeNumberTextBox = new System.Windows.Forms.TextBox();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.prizeAmountTextBox = new System.Windows.Forms.TextBox();
            this.prizePercentageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(73)))), ((int)(((byte)(51)))));
            this.headerLabel.Location = new System.Drawing.Point(42, 41);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(404, 68);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "Create Prize";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(236, 635);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(210, 55);
            this.createPrizeButton.TabIndex = 20;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // placeNumerLabel
            // 
            this.placeNumerLabel.AutoSize = true;
            this.placeNumerLabel.Location = new System.Drawing.Point(67, 202);
            this.placeNumerLabel.Name = "placeNumerLabel";
            this.placeNumerLabel.Size = new System.Drawing.Size(210, 45);
            this.placeNumerLabel.TabIndex = 21;
            this.placeNumerLabel.Text = "Place Number";
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(67, 292);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(180, 45);
            this.placeNameLabel.TabIndex = 22;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Location = new System.Drawing.Point(67, 378);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(203, 45);
            this.prizeAmountLabel.TabIndex = 23;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Location = new System.Drawing.Point(67, 516);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(243, 45);
            this.prizePercentageLabel.TabIndex = 24;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Location = new System.Drawing.Point(264, 441);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(88, 45);
            this.orLabel.TabIndex = 25;
            this.orLabel.Text = "-OR-";
            this.orLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // placeNumberTextBox
            // 
            this.placeNumberTextBox.Location = new System.Drawing.Point(320, 200);
            this.placeNumberTextBox.Name = "placeNumberTextBox";
            this.placeNumberTextBox.Size = new System.Drawing.Size(232, 50);
            this.placeNumberTextBox.TabIndex = 26;
            this.placeNumberTextBox.Text = "1";
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.Location = new System.Drawing.Point(321, 289);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(232, 50);
            this.placeNameTextBox.TabIndex = 27;
            this.placeNameTextBox.Text = "First Place";
            // 
            // prizeAmountTextBox
            // 
            this.prizeAmountTextBox.Location = new System.Drawing.Point(320, 375);
            this.prizeAmountTextBox.Name = "prizeAmountTextBox";
            this.prizeAmountTextBox.Size = new System.Drawing.Size(232, 50);
            this.prizeAmountTextBox.TabIndex = 28;
            this.prizeAmountTextBox.Text = "100";
            // 
            // prizePercentageTextBox
            // 
            this.prizePercentageTextBox.Location = new System.Drawing.Point(321, 513);
            this.prizePercentageTextBox.Name = "prizePercentageTextBox";
            this.prizePercentageTextBox.Size = new System.Drawing.Size(232, 50);
            this.prizePercentageTextBox.TabIndex = 29;
            this.prizePercentageTextBox.Text = "0";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 793);
            this.Controls.Add(this.prizePercentageTextBox);
            this.Controls.Add(this.prizeAmountTextBox);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeNumberTextBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumerLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatePrizeForm";
            this.Text = "CreatePrizeForm";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label placeNumerLabel;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label prizePercentageLabel;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.TextBox placeNumberTextBox;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.TextBox prizeAmountTextBox;
        private System.Windows.Forms.TextBox prizePercentageTextBox;
    }
}