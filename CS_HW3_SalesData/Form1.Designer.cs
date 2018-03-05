namespace CS_HW3_SalesData
{
    partial class Form1
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
            this.SalesDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SaleCountOutputLabel = new System.Windows.Forms.Label();
            this.AddSaleButton = new System.Windows.Forms.Button();
            this.SaleAmtTextBox = new System.Windows.Forms.TextBox();
            this.RepNameTextBox = new System.Windows.Forms.TextBox();
            this.SaleCountLabel = new System.Windows.Forms.Label();
            this.SaleAmtLabel = new System.Windows.Forms.Label();
            this.RepNameLabel = new System.Windows.Forms.Label();
            this.HighestButton = new System.Windows.Forms.Button();
            this.NumToReturnTextBox = new System.Windows.Forms.TextBox();
            this.LowestButton = new System.Windows.Forms.Button();
            this.FindTopNButton = new System.Windows.Forms.Button();
            this.ClearSalesDataButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.SalesDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesDataGroupBox
            // 
            this.SalesDataGroupBox.Controls.Add(this.SaleCountOutputLabel);
            this.SalesDataGroupBox.Controls.Add(this.AddSaleButton);
            this.SalesDataGroupBox.Controls.Add(this.SaleAmtTextBox);
            this.SalesDataGroupBox.Controls.Add(this.RepNameTextBox);
            this.SalesDataGroupBox.Controls.Add(this.SaleCountLabel);
            this.SalesDataGroupBox.Controls.Add(this.SaleAmtLabel);
            this.SalesDataGroupBox.Controls.Add(this.RepNameLabel);
            this.SalesDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SalesDataGroupBox.Name = "SalesDataGroupBox";
            this.SalesDataGroupBox.Size = new System.Drawing.Size(191, 137);
            this.SalesDataGroupBox.TabIndex = 0;
            this.SalesDataGroupBox.TabStop = false;
            this.SalesDataGroupBox.Text = "Sales Data";
            // 
            // SaleCountOutputLabel
            // 
            this.SaleCountOutputLabel.AutoSize = true;
            this.SaleCountOutputLabel.Location = new System.Drawing.Point(164, 79);
            this.SaleCountOutputLabel.Name = "SaleCountOutputLabel";
            this.SaleCountOutputLabel.Size = new System.Drawing.Size(16, 13);
            this.SaleCountOutputLabel.TabIndex = 7;
            this.SaleCountOutputLabel.Text = "---";
            // 
            // AddSaleButton
            // 
            this.AddSaleButton.Location = new System.Drawing.Point(105, 102);
            this.AddSaleButton.Name = "AddSaleButton";
            this.AddSaleButton.Size = new System.Drawing.Size(75, 23);
            this.AddSaleButton.TabIndex = 6;
            this.AddSaleButton.Text = "Add Sale";
            this.AddSaleButton.UseVisualStyleBackColor = true;
            this.AddSaleButton.Click += new System.EventHandler(this.AddSaleButton_Click);
            // 
            // SaleAmtTextBox
            // 
            this.SaleAmtTextBox.Location = new System.Drawing.Point(80, 53);
            this.SaleAmtTextBox.Name = "SaleAmtTextBox";
            this.SaleAmtTextBox.Size = new System.Drawing.Size(100, 20);
            this.SaleAmtTextBox.TabIndex = 4;
            // 
            // RepNameTextBox
            // 
            this.RepNameTextBox.Location = new System.Drawing.Point(80, 27);
            this.RepNameTextBox.Name = "RepNameTextBox";
            this.RepNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.RepNameTextBox.TabIndex = 3;
            // 
            // SaleCountLabel
            // 
            this.SaleCountLabel.AutoSize = true;
            this.SaleCountLabel.Location = new System.Drawing.Point(13, 79);
            this.SaleCountLabel.Name = "SaleCountLabel";
            this.SaleCountLabel.Size = new System.Drawing.Size(62, 13);
            this.SaleCountLabel.TabIndex = 2;
            this.SaleCountLabel.Text = "Sale Count:";
            // 
            // SaleAmtLabel
            // 
            this.SaleAmtLabel.AutoSize = true;
            this.SaleAmtLabel.Location = new System.Drawing.Point(4, 56);
            this.SaleAmtLabel.Name = "SaleAmtLabel";
            this.SaleAmtLabel.Size = new System.Drawing.Size(70, 13);
            this.SaleAmtLabel.TabIndex = 1;
            this.SaleAmtLabel.Text = "Sale Amount:";
            // 
            // RepNameLabel
            // 
            this.RepNameLabel.AutoSize = true;
            this.RepNameLabel.Location = new System.Drawing.Point(13, 31);
            this.RepNameLabel.Name = "RepNameLabel";
            this.RepNameLabel.Size = new System.Drawing.Size(61, 13);
            this.RepNameLabel.TabIndex = 0;
            this.RepNameLabel.Text = "Rep Name:";
            // 
            // HighestButton
            // 
            this.HighestButton.Location = new System.Drawing.Point(19, 168);
            this.HighestButton.Name = "HighestButton";
            this.HighestButton.Size = new System.Drawing.Size(75, 23);
            this.HighestButton.TabIndex = 1;
            this.HighestButton.Text = "Highest";
            this.HighestButton.UseVisualStyleBackColor = true;
            this.HighestButton.Click += new System.EventHandler(this.HighestButton_Click);
            // 
            // NumToReturnTextBox
            // 
            this.NumToReturnTextBox.Location = new System.Drawing.Point(103, 168);
            this.NumToReturnTextBox.Name = "NumToReturnTextBox";
            this.NumToReturnTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumToReturnTextBox.TabIndex = 2;
            // 
            // LowestButton
            // 
            this.LowestButton.Location = new System.Drawing.Point(19, 197);
            this.LowestButton.Name = "LowestButton";
            this.LowestButton.Size = new System.Drawing.Size(75, 23);
            this.LowestButton.TabIndex = 3;
            this.LowestButton.Text = "Lowest";
            this.LowestButton.UseVisualStyleBackColor = true;
            this.LowestButton.Click += new System.EventHandler(this.LowestButton_Click);
            // 
            // FindTopNButton
            // 
            this.FindTopNButton.Location = new System.Drawing.Point(128, 194);
            this.FindTopNButton.Name = "FindTopNButton";
            this.FindTopNButton.Size = new System.Drawing.Size(75, 23);
            this.FindTopNButton.TabIndex = 4;
            this.FindTopNButton.Text = "Find Top N";
            this.FindTopNButton.UseVisualStyleBackColor = true;
            this.FindTopNButton.Click += new System.EventHandler(this.FindTopNButton_Click);
            // 
            // ClearSalesDataButton
            // 
            this.ClearSalesDataButton.Location = new System.Drawing.Point(12, 238);
            this.ClearSalesDataButton.Name = "ClearSalesDataButton";
            this.ClearSalesDataButton.Size = new System.Drawing.Size(96, 23);
            this.ClearSalesDataButton.TabIndex = 5;
            this.ClearSalesDataButton.Text = "Clear Sales Data";
            this.ClearSalesDataButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(114, 238);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(96, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 267);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // OutputListBox
            // 
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.Location = new System.Drawing.Point(218, 12);
            this.OutputListBox.Name = "OutputListBox";
            this.OutputListBox.Size = new System.Drawing.Size(199, 277);
            this.OutputListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.AddSaleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 300);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ClearSalesDataButton);
            this.Controls.Add(this.FindTopNButton);
            this.Controls.Add(this.LowestButton);
            this.Controls.Add(this.NumToReturnTextBox);
            this.Controls.Add(this.HighestButton);
            this.Controls.Add(this.SalesDataGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SalesDataGroupBox.ResumeLayout(false);
            this.SalesDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SalesDataGroupBox;
        private System.Windows.Forms.Label SaleCountOutputLabel;
        private System.Windows.Forms.Button AddSaleButton;
        private System.Windows.Forms.TextBox SaleAmtTextBox;
        private System.Windows.Forms.TextBox RepNameTextBox;
        private System.Windows.Forms.Label SaleCountLabel;
        private System.Windows.Forms.Label SaleAmtLabel;
        private System.Windows.Forms.Label RepNameLabel;
        private System.Windows.Forms.Button HighestButton;
        private System.Windows.Forms.TextBox NumToReturnTextBox;
        private System.Windows.Forms.Button LowestButton;
        private System.Windows.Forms.Button FindTopNButton;
        private System.Windows.Forms.Button ClearSalesDataButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox OutputListBox;
    }
}

