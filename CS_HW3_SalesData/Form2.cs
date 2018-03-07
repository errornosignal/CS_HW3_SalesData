using System;
using System.Windows.Forms;

namespace CS_HW3_SalesData
{
    /// <summary>
    /// Form2 class
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public bool SecondFormNumIsValid = true;
        public int SecondFormNumToFind = 0;

        /// <summary>
        /// Loads desired initial form state.
        /// </summary>
        /// <param name="sender">Form1 object</param>
        /// <param name="e">Form1 EventArgs</param>
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Form2TextBox.TextAlign = HorizontalAlignment.Right;
            this.Form2TextBox.Clear();
            this.Form2TextBox.Focus();
        }

        /// <summary>
        /// Gets data from Form2TextBox.
        /// </summary>
        /// <param name="sender">Form2Button object</param>
        /// <param name="e">Form2Button EventArgs</param>
        private void Form2Button_Click(object sender, EventArgs e)
        {
            this.SecondFormNumIsValid = true;
            this.SecondFormNumToFind = 0;

            SecondFormNumIsValid = int.TryParse(Form2TextBox.Text, out var NumToFind);

            if (SecondFormNumIsValid && NumToFind > 0)
            {
                this.SecondFormNumToFind = NumToFind;
            }
            else if (SecondFormNumIsValid && NumToFind <= 0)
            {
                DisplayNoSense();
            }
            else { /*doNothing*/}
        }

        /// <summary>
        /// /// <summary>
        /// Displays error feedback when top n qty is zero or less.
        /// </summary>
        /// </summary>
        private static void DisplayNoSense()
        {
            MessageBox.Show("That makes no sense... ", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        /// <param name="sender">Form2ExitButton object</param>
        /// <param name="e">Form2ExitButton EventArgs</param>
        private void Form2ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}