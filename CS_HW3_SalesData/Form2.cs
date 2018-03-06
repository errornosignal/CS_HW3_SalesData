using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_HW3_SalesData
{
    public partial class Form2 : Form
    {
        public bool SecondFormNumIsValid = true;
        public int SecondFormNumToFind = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2Button_Click(object sender, EventArgs e)
        {
            SecondFormNumIsValid = true;
            SecondFormNumToFind = 0;

            SecondFormNumIsValid = int.TryParse(Form2TextBox.Text, out var NumToFind);

            if (SecondFormNumIsValid && NumToFind > 0)
            {
                SecondFormNumToFind = NumToFind;
            }
            else if (SecondFormNumIsValid && NumToFind <= 0)
            {
                MessageBox.Show("That makes no sense... ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { /*doNothing*/}
        }

        private void Form2ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form2 Exit Button Fired.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }
    }
}
