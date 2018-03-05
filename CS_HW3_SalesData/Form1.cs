using System;
using System.CodeDom.Compiler;
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

        private Form2 SecondForm = new Form2();

        List<Sale> SalesList = new List<Sale>();
        int SaleNumber = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            AddSales();
        }

        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            var RepName = SplitString(RepNameTextBox.Text);
            string FormattedRepName = FormatName(RepName);
            var AmtIsValid = decimal.TryParse(SaleAmtTextBox.Text, out decimal NewDecimal);

            if (FormattedRepName == "")
            {
                //display error on invalid name entered
                DisplayNameInputError();
                RepNameTextBox.Focus();
            }
            else if (!AmtIsValid)
            {
                //display error on invalid amount entered
                DisplayAmountInputError();
                SaleAmtTextBox.Clear();
                SaleAmtTextBox.Focus();
            }
            else if ((FormattedRepName.Length > 0) && AmtIsValid)
            {
                //add new Sale object
                SalesList.Add(new Sale(SaleNumber, FormattedRepName, NewDecimal));

                //clear and focus
                RepNameTextBox.Clear();
                SaleAmtTextBox.Clear();
                RepNameTextBox.Focus();

                //increment sale counter
                SaleNumber++;

                //update sale count label
                SaleCountOutputLabel.Text = SaleNumber.ToString();

                //reset datasource
                ResetDatasource();
            }
        }

        private void AddSales()
        {
            SalesList.Add(new Sale(SaleNumber, FixName("Alan A."), 50000.00m));
            SaleNumber++;
            SalesList.Add(new Sale(SaleNumber, FixName("Bob B."), 152000.99m));
            SaleNumber++;
            SalesList.Add(new Sale(SaleNumber, FixName("Chris C."), 35000.12m));
            SaleNumber++;
            SalesList.Add(new Sale(SaleNumber, FixName("Dale D."), 76000.10m));
            SaleNumber++;
            SalesList.Add(new Sale(SaleNumber, FixName("Eric. E"), 133000.00m));
            SaleNumber++;
            ResetDatasource();
            SaleCountOutputLabel.Text = SaleNumber.ToString();
        }

        public string FixName(string String)
        {
            var NewString = SplitString(String);
            return FormatName(NewString);
        }

        private void HighestButton_Click(object sender, EventArgs e)
        {
            var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
            NumToReturnTextBox.Text = GetHighestRepBySales(SortedSalesList).ToString();
        }

        private void LowestButton_Click(object sender, EventArgs e)
        {
            var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
            NumToReturnTextBox.Text = GetLowestRepBySales(SortedSalesList).ToString();
        }

        private void FindTopNButton_Click(object sender, EventArgs e)
        {
            var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
            SecondForm.ShowDialog();
            SecondForm.Form2TextBox.Focus();

            var NumIsValid = int.TryParse(SecondForm.Form2TextBox.Text, out int NumToFind);
            if (!NumIsValid)
            {
                DisplayNumIsInvalid01();
                SecondForm.Form2TextBox.Clear();
                SecondForm.Form2TextBox.Focus();
            }
            else if (NumToFind > SortedSalesList.Count() || NumToFind < 1)
            {
                DisplayNumIsInvalid02();
                SecondForm.Form2TextBox.Clear();
                SecondForm.Form2TextBox.Focus();
            }
            else
            {
                SecondForm.Form2TextBox.Clear();
                SecondForm.Form2TextBox.Focus();
                SortedSalesList.Reverse();
                OutputListBox.DataSource = GetTopNBySales(SortedSalesList, NumToFind);
            }
        }

        //private object GetTopNBySales(List<Sale> sortedSalesList, object text)
        //{
        //    throw new NotImplementedException();
        //}

        private List<Sale> GetTopNBySales(List<Sale> SortedSalesList, int num)
        {
            var FirstNItems = SortedSalesList.GetRange(0, num);
            return FirstNItems;
        }

        public Sale GetHighestRepBySales(List<Sale> SalesList)
        {
            return SalesList[SalesList.Count - 1];
        }

        public Sale GetLowestRepBySales(List<Sale> SalesList)
        {
            return SalesList[0];
        }


        private void ResetDatasource()
        {
            OutputListBox.DataSource = null;
            OutputListBox.DataSource = SalesList;
        }

        private void DisplayNameInputError()
        {
            MessageBox.Show("First and Last name are requred.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayAmountInputError()
        {
            MessageBox.Show("Sale amount was not a number.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayNumIsInvalid01()
        {
            MessageBox.Show("Number was not an integer.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayNumIsInvalid02()
        {
            MessageBox.Show("Number must be >= 1 and < Sale Count.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string[] SplitString(string String)
        {
            string[] StringArray = String.Split(' ');
            return StringArray;
        }

        public string FormatName(string[] array)
        {
            if (array.Length >= 2)
            {
                return array[1] + ", " + array[0];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Sale class
        /// </summary>
        public class Sale
        {
            public Sale(int saleNumber, string repName, decimal saleAmt)
            {
                SaleNumber = saleNumber;
                RepName = repName;
                SaleAmt = saleAmt;
            }

            int SaleNumber { get; set; }
            string RepName { get; set; }
            public decimal SaleAmt { get; set; }
   
            public override string ToString()
            {
                return RepName + " " + $"{SaleAmt:C}";
            } 
        }

       
    }
}
