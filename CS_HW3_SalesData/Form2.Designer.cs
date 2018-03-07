namespace CS_HW3_SalesData
{
    partial class Form2
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
            this.Form2Label = new System.Windows.Forms.Label();
            this.Form2TextBox = new System.Windows.Forms.TextBox();
            this.Form2Button = new System.Windows.Forms.Button();
            this.Form2ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form2Label
            // 
            this.Form2Label.AutoSize = true;
            this.Form2Label.Location = new System.Drawing.Point(12, 9);
            this.Form2Label.Name = "Form2Label";
            this.Form2Label.Size = new System.Drawing.Size(157, 13);
            this.Form2Label.TabIndex = 0;
            this.Form2Label.Text = "Number of Top Sales to Return:";
            // 
            // Form2TextBox
            // 
            this.Form2TextBox.Location = new System.Drawing.Point(69, 40);
            this.Form2TextBox.Name = "Form2TextBox";
            this.Form2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Form2TextBox.TabIndex = 0;
            // 
            // Form2Button
            // 
            this.Form2Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form2Button.Location = new System.Drawing.Point(94, 69);
            this.Form2Button.Name = "Form2Button";
            this.Form2Button.Size = new System.Drawing.Size(75, 23);
            this.Form2Button.TabIndex = 1;
            this.Form2Button.Text = "Submit";
            this.Form2Button.UseVisualStyleBackColor = true;
            this.Form2Button.Click += new System.EventHandler(this.Form2Button_Click);
            // 
            // Form2ExitButton
            // 
            this.Form2ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Form2ExitButton.Location = new System.Drawing.Point(12, 40);
            this.Form2ExitButton.Name = "Form2ExitButton";
            this.Form2ExitButton.Size = new System.Drawing.Size(40, 23);
            this.Form2ExitButton.TabIndex = 2;
            this.Form2ExitButton.Text = "Exit";
            this.Form2ExitButton.UseVisualStyleBackColor = true;
            this.Form2ExitButton.Click += new System.EventHandler(this.Form2ExitButton_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Form2Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form2ExitButton;
            this.ClientSize = new System.Drawing.Size(181, 104);
            this.Controls.Add(this.Form2ExitButton);
            this.Controls.Add(this.Form2Button);
            this.Controls.Add(this.Form2TextBox);
            this.Controls.Add(this.Form2Label);
            this.Name = "Form2";
            this.Text = "Find Top N";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form2Label;
        public System.Windows.Forms.TextBox Form2TextBox;
        private System.Windows.Forms.Button Form2Button;
        private System.Windows.Forms.Button Form2ExitButton;
    }
}