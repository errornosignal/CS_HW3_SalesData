using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <Sale> SalesList = new List<Sale>();

        //sort with
        ///!!!//SalesList.OrderBy(x => x.SaleAmt);
        //var sortedList = SalesList.OrderBy(i => i.SaleAmt);

        int SaleNumber = 0;

        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            var RepName = RepNameTextBox.Text;
            var isValid = decimal.TryParse(SaleAmtTextBox.Text, out decimal NewDecimal);

            if (!isValid)
            {
                //display error on invalid amount entered
                MessageBox.Show("Sale amount was not a number.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaleAmtTextBox.Clear();
                SaleAmtTextBox.Focus();
            }
            else
            {
                //add new Sale object
                SalesList.Add(new Sale(SaleNumber, RepName, NewDecimal));
                SaleNumber++;

                //update sale count label
                SaleCountOutputLabel.Text = SaleNumber.ToString();

                //clear and focus
                RepNameTextBox.Clear();
                SaleAmtTextBox.Clear();
                RepNameTextBox.Focus();

                //reset datasource
                OutputListBox.DataSource = null;
                OutputListBox.DataSource = SalesList;
            }
            
        }

        /// <summary>
        /// Sale class
        /// </summary>
        public class Sale
        {
            public Sale(int saleNumber, string repName, decimal saleAmt)
            {
                this.SaleNumber = saleNumber;
                this.RepName = repName;
                this.SaleAmt = saleAmt;
            }

            public int SaleNumber { get; set; }
            public string RepName { get; set; }
            public decimal SaleAmt { get; set; }

            public override string ToString()
            {
                return RepName + " " + SaleAmt;
            }
        }

    }
}
