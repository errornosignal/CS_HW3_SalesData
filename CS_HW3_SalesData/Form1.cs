using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_HW3_SalesData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 SecondForm = new Form2();

        private List<Sale> SalesList = new List<Sale>();
        private int SaleNumber = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            SaleCountOutputTextBox.TextAlign = HorizontalAlignment.Right;
            NumToReturnTextBox.TextAlign = HorizontalAlignment.Right;
            AddSales();
        }

        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            var RepName = SplitString(RepNameTextBox.Text);
            var FormattedRepName = FormatName(RepName);
            var AmtIsValid = decimal.TryParse(SaleAmtTextBox.Text, out var NewDecimal);

            if (FormattedRepName == "")
            {
                DisplayNameInputError();
                RepNameTextBox.Focus();
            }
            else if (!AmtIsValid)
            {
                DisplayAmountInputError();
                SaleAmtTextBox.Clear();
                SaleAmtTextBox.Focus();
            }
            else if (FormattedRepName.Length > 0)
            {
                SalesList.Add(new Sale(FormattedRepName, NewDecimal));
                
                RepNameTextBox.Clear();
                SaleAmtTextBox.Clear();
                RepNameTextBox.Focus();

                SaleNumber++;
                SaleCountOutputTextBox.Text = SaleNumber.ToString();
                ResetDatasource();
            }
        }

        /// <summary>
        /// Pre-fills sales data for ease of testing
        /// </summary>
        private void AddSales()
        {
            SalesList.Add(new Sale(FixName("Alan A."), 50001.00m));
            SalesList.Add(new Sale(FixName("Bob B."), 152000.99m));
            SalesList.Add(new Sale(FixName("Chris C."), 35000.12m));
            SalesList.Add(new Sale(FixName("Dale D."), 76000m));
            SalesList.Add(new Sale(FixName("Eric. E"), 133000.00m));
            SaleNumber += 5;
            ResetDatasource();
            SaleCountOutputTextBox.Text = SaleNumber.ToString();
        }

        private static string FixName(string String)
        {
            var NewString = SplitString(String);
            return FormatName(NewString);
        }

        private void HighestButton_Click(object sender, EventArgs e)
        {
            if (SalesList.Count > 0)
            {
                var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
                NumToReturnTextBox.Text = GetHighestRepBySales(SortedSalesList).ToString();
            }
            else
            {
                DisplayNoSales();
            }
        }

        private void LowestButton_Click(object sender, EventArgs e)
        {
            if (SalesList.Count > 0)
            {
                var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
                NumToReturnTextBox.Text = GetLowestRepBySales(SortedSalesList).ToString();
            }
            else
            {
                DisplayNoSales();
            }
        }

        private void FindTopNButton_Click(object sender, EventArgs e)
        {
            SecondForm.SecondFormNumIsValid = true;
            SecondForm.SecondFormNumToFind = 0;

            DisplaySecondForm();

            var SortedSalesList = SalesList.OrderBy(x => x.SaleAmt).ToList();
            var NumToFind = SecondForm.SecondFormNumToFind;
            var NumIsValid = SecondForm.SecondFormNumIsValid;

            if (NumToFind == 0 && !NumIsValid)
            {
                DisplayNoInput();
            }
            else if (NumToFind == 0 && NumIsValid)
            {/*doNothing()*/} //allow SecondForm to close without an issue

            else if (!NumIsValid)
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
                SortedSalesList.Reverse();
                OutputListBox.DataSource = GetTopNBySales(SortedSalesList, NumToFind);
            }
        }

        private void DisplaySecondForm()
        {
            SecondForm.ShowDialog();
            SecondForm.Form2TextBox.Clear();
            SecondForm.Form2TextBox.Focus();
        }

        private static List<Sale> GetTopNBySales(List<Sale> SortedSalesList, int num)
        {
            var FirstNItems = SortedSalesList.GetRange(0, num);
            return FirstNItems;
        }

        private static Sale GetHighestRepBySales(List<Sale> SalesList)
        {
            return SalesList[SalesList.Count - 1];
        }

        private static Sale GetLowestRepBySales(List<Sale> SalesList)
        {

            return SalesList[0];
        }

        private void ResetDatasource()
        {
            OutputListBox.DataSource = null;
            OutputListBox.DataSource = SalesList;
        }

        private static void DisplayNameInputError()
        {
            MessageBox.Show("First and Last name are requred.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void DisplayAmountInputError()
        {
            MessageBox.Show("Sale amount was not a number.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void DisplayNumIsInvalid01()
        {
            MessageBox.Show("Number was not an integer.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void DisplayNumIsInvalid02()
        {
            MessageBox.Show("Number must be between 1 and \n" +
                            "the current Sale Count.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void DisplayNoInput()
        {
            MessageBox.Show("You didn't enter a number...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void DisplayNoSales()
        {
            MessageBox.Show("There is no sales data.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private static string[] SplitString(string String)
        {
            var StringArray = String.Split(' ');
            return StringArray;
        }

        private static string FormatName(string[] array)
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetDatasource();
            RepNameTextBox.Clear();
            SaleAmtTextBox.Clear();
            NumToReturnTextBox.Clear();
            RepNameTextBox.Focus();
        }

        private void ClearSalesDataButton_Click(object sender, EventArgs e)
        {
            SaleNumber = 0;
            SaleCountOutputTextBox.Text = SaleNumber.ToString();
            SalesList.Clear();
            ResetDatasource();
            RepNameTextBox.Clear();
            SaleAmtTextBox.Clear();
            NumToReturnTextBox.Clear();
            RepNameTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form1 Exit Button Fired.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        /// <summary>
        /// Sale class
        /// </summary>
        private class Sale
        {
            public Sale(string repName, decimal saleAmt)
            {
                RepName = repName;
                SaleAmt = saleAmt;
            }

            private string RepName { get; }
            public decimal SaleAmt { get; }

            public override string ToString()
            {
                return RepName + " " + $"{SaleAmt:C}";
            } 
        } 
    }
}