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
            this.SuspendLayout();
            // 
            // Form2Label
            // 
            this.Form2Label.AutoSize = true;
            this.Form2Label.Location = new System.Drawing.Point(12, 19);
            this.Form2Label.Name = "Form2Label";
            this.Form2Label.Size = new System.Drawing.Size(157, 13);
            this.Form2Label.TabIndex = 0;
            this.Form2Label.Text = "Number of Top Sales to Return:";
            // 
            // Form2TextBox
            // 
            this.Form2TextBox.Location = new System.Drawing.Point(12, 44);
            this.Form2TextBox.Name = "Form2TextBox";
            this.Form2TextBox.Size = new System.Drawing.Size(100, 20);
            this.Form2TextBox.TabIndex = 1;
            // 
            // Form2Button
            // 
            this.Form2Button.Location = new System.Drawing.Point(131, 44);
            this.Form2Button.Name = "Form2Button";
            this.Form2Button.Size = new System.Drawing.Size(75, 23);
            this.Form2Button.TabIndex = 2;
            this.Form2Button.Text = "Enter";
            this.Form2Button.UseVisualStyleBackColor = true;
            this.Form2Button.Click += new System.EventHandler(this.Form2Button_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Form2Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Form2Button;
            this.ClientSize = new System.Drawing.Size(218, 76);
            this.Controls.Add(this.Form2Button);
            this.Controls.Add(this.Form2TextBox);
            this.Controls.Add(this.Form2Label);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form2Label;
        public System.Windows.Forms.TextBox Form2TextBox;
        private System.Windows.Forms.Button Form2Button;
    }
}