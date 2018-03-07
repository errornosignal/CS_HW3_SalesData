using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS_HW3_SalesData
{
    /// <summary>
    /// Form1 class
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form2 SecondForm = new Form2();
        private List<Sale> SalesList = new List<Sale>();
        private int SaleNumber = 0;

        /// <summary>
        /// Loads desired initial form state.
        /// </summary>
        /// <param name="sender">Form1 object</param>
        /// <param name="e">Form1 EventArgs</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.RepNameTextBox.TextAlign = HorizontalAlignment.Right;
            this.SaleAmtTextBox.TextAlign = HorizontalAlignment.Right;
            this.SaleCountOutputTextBox.TextAlign = HorizontalAlignment.Right;
            this.AddTestSales();
        }

        /// <summary>
        /// Adds a Sale object to SaleList.
        /// </summary>
        /// <param name="sender">AddSaleButton object</param>
        /// <param name="e">AddSaleButton EventArgs</param>
        private void AddSaleButton_Click(object sender, EventArgs e)
        {
            var RepName = SplitString(RepNameTextBox.Text);
            var FormattedRepName = FormatName(RepName);
            var AmtIsValid = decimal.TryParse(SaleAmtTextBox.Text, out var NewDecimal);

            if (FormattedRepName == "")
            {
                DisplayNameInputError();
                this.RepNameTextBox.Focus();
            }
            else if (!AmtIsValid)
            {
                DisplayAmountInputError();
                this.SaleAmtTextBox.Clear();
                this.SaleAmtTextBox.Focus();
            }
            else if (FormattedRepName.Length > 0)
            {
                SalesList.Add(new Sale(FormattedRepName, NewDecimal));

                this.RepNameTextBox.Clear();
                this.SaleAmtTextBox.Clear();
                this.RepNameTextBox.Focus();

                this.SaleNumber++;
                this.SaleCountOutputTextBox.Text = SaleNumber.ToString();
                this.ResetDatasource();
            }
        }

        /// <summary>
        /// Pre-fills valid sales data for ease of testing.
        /// </summary>
        private void AddTestSales()
        {
            this.SalesList.Add(new Sale(FixName("Alan A."), 50001m));
            this.SalesList.Add(new Sale(FixName("Bob B."), 152000.99m));
            this.SalesList.Add(new Sale(FixName("Chris C."), 35000.12m));
            this.SalesList.Add(new Sale(FixName("Dale D."), 76000m));
            this.SalesList.Add(new Sale(FixName("Eric. E"), 133000.00m));
            this.SaleNumber += 5;
            this.ResetDatasource();
            this.SaleCountOutputTextBox.Text = this.SaleNumber.ToString();
        }

        /// <summary>
        /// Splits a string on whitespace.
        /// </summary>
        /// <param name="String">String to reformat</param>
        /// <returns>Formatted string</returns>
        private static string FixName(string String)
        {
            var NewString = SplitString(String);
            return FormatName(NewString);
        }

        /// <summary>
        /// Stores input string, split on whitespace, as string array.
        /// </summary>
        /// <param name="String">RepName string input by user</param>
        /// <returns>String array of RepName</returns>
        private static string[] SplitString(string String)
        {
            var StringArray = String.Split(' ');
            return StringArray;
        }

        /// <summary>
        /// Formats string to desired name output.
        /// </summary>
        /// <param name="array">String array of RepName</param>
        /// <returns>Formatted RepName string array as string</returns>
        private static string FormatName(string[] array)
        {
            const int LengthChk = 2;
            const int LastNamePos = 1;
            const int FirstNamePos = 0;

            if (array.Length >= LengthChk)
            {
                return array[LastNamePos] + ", " + array[FirstNamePos];
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Displys highest amount sale record or reports no sale data exists.
        /// </summary>
        /// <param name="sender">HighestButton object</param>
        /// <param name="e">HighestButton EventArgs</param>
        private void HighestButton_Click(object sender, EventArgs e)
        {
            if (SalesList.Count > 0)
            {
                var SortedSalesList = this.SalesList.OrderBy(x => x.SaleAmt).ToList();
                this.HighLowTextBox.Text = GetHighestRepBySales(SortedSalesList).ToString();
            }
            else
            {
                DisplayNoSales();
            }
        }

        /// <summary>
        /// Displys lowest amount sale record or reports no sale data exists.
        /// </summary>
        /// <param name="sender">LowestButton object</param>
        /// <param name="e">LowestButton EventArgs</param>
        private void LowestButton_Click(object sender, EventArgs e)
        {
            if (SalesList.Count > 0)
            {
                var SortedSalesList = this.SalesList.OrderBy(x => x.SaleAmt).ToList();
                this.HighLowTextBox.Text = GetLowestRepBySales(SortedSalesList).ToString();
            }
            else
            {
                DisplayNoSales();
            }
        }

        /// <summary>
        /// Displays top N Sale objects, sorted in desc order.
        /// </summary>
        /// <param name="sender">FindTopNButton object</param>
        /// <param name="e">FindTopNButton EventArgs</param>
        private void FindTopNButton_Click(object sender, EventArgs e)
        {
            this.SecondForm.SecondFormNumIsValid = true;
            this.SecondForm.SecondFormNumToFind = 0;

            DisplaySecondForm();

            var SortedSalesList = this.SalesList.OrderBy(x => x.SaleAmt).ToList();
            var NumToFind = this.SecondForm.SecondFormNumToFind;
            var NumIsValid = this.SecondForm.SecondFormNumIsValid;

            if (NumToFind == 0 && !NumIsValid)
            {
                DisplayNoInput();
            }
            else if (NumToFind == 0 && NumIsValid)
            {/*doNothing()*/} //allow SecondForm to close without an issue

            else if (!NumIsValid)
            {
                DisplayNumIsInvalid01();
                this.SecondForm.Form2TextBox.Clear();
                this.SecondForm.Form2TextBox.Focus();
            }
            else if (NumToFind > SortedSalesList.Count() || NumToFind < 1)
            {
                DisplayNumIsInvalid02();
                this.SecondForm.Form2TextBox.Clear();
                this.SecondForm.Form2TextBox.Focus();
            }
            else
            {
                SortedSalesList.Reverse();
                this.SecondForm.Form2TextBox.Clear();
                this.OutputListBox.DataSource = GetTopNBySales(SortedSalesList, NumToFind);
            }
        }

        /// <summary>
        /// Displays SecondForm for FindTopN.
        /// </summary>
        private void DisplaySecondForm()
        {
            this.SecondForm.ShowDialog();
            this.SecondForm.Form2TextBox.Clear();
            this.SecondForm.Form2TextBox.Focus();
        }

        /// <summary>
        /// Gets top N sales by amount.
        /// </summary>
        /// <param name="SortedSalesList">List of Sale objects</param>
        /// <param name="num">Number of Sales objects to return</param>
        /// <returns>Sorted list of top n Sale objects</returns>
        private static List<Sale> GetTopNBySales(List<Sale> SortedSalesList, int num)
        {
            var FirstNItems = SortedSalesList.GetRange(0, num);
            return FirstNItems;
        }

        /// <summary>
        /// Gets highest Sale by amount.
        /// </summary>
        /// <param name="SalesList">List of Sale objects</param>
        /// <returns>Highest Sale objects by SaleAmt</returns>
        private static Sale GetHighestRepBySales(List<Sale> SalesList)
        {
            return SalesList[SalesList.Count - 1];
        }

        /// <summary>
        /// Gets lowest Sale by amount.
        /// </summary>
        /// <param name="SalesList">List of Sale objects</param>
        /// <returns>Lowest Sale objects by SaleAmt</returns>
        private static Sale GetLowestRepBySales(List<Sale> SalesList)
        {

            return SalesList[0];
        }

        /// <summary>
        /// Reset datasource for OutputListBox.
        /// </summary>
        private void ResetDatasource()
        {
            this.OutputListBox.DataSource = null;
            this.OutputListBox.DataSource = this.SalesList;
        }

        /// <summary>
        /// Displays input error feedback for RepNameTextBox on incomplete input.
        /// </summary>
        private static void DisplayNameInputError()
        {
            MessageBox.Show("First and Last name are requred.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays input error feedback for SaleAmtTextBox on NAN input.
        /// </summary>
        private static void DisplayAmountInputError()
        {
            MessageBox.Show("Sale amount was not a number.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays input error feedback for SecondForm.Form2TextBox on non-integer input.
        /// </summary>
        private static void DisplayNumIsInvalid01()
        {
            MessageBox.Show("Number was not an integer.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>.
        /// Displays input error feedback for SecondForm.Form2TextBox on out-of-range input
        /// </summary>
        private static void DisplayNumIsInvalid02()
        {
            MessageBox.Show("Number must be between 1 and \n" +
                            "the current Sale Count.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays input error feedback for SecondForm.Form2TextBox on NAN input.
        /// </summary>
        private static void DisplayNoInput()
        {
            MessageBox.Show("You didn't enter a number...", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays error feedback for LowestButton/HighestButton when no records exist in SalesList.
        /// </summary>
        private static void DisplayNoSales()
        {
            MessageBox.Show("There is no sales data.", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Calls ResetFormState() method.
        /// </summary>
        /// <param name="sender">ResetButton object</param>
        /// <param name="e">ResetButton EventArgs</param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetFormState();
        }

        /// <summary>
        /// Calls ClearSalesData() and ResetFormState() methods.
        /// </summary>
        /// <param name="sender">ClearSalesDataButton object</param>
        /// <param name="e">ClearSalesDataButton EventArgs</param>
        private void ClearSalesDataButton_Click(object sender, EventArgs e)
        {
            ClearSalesData();
            ResetFormState();
        }

        /// <summary>
        /// Remove all Sale objects from SalesList.
        /// </summary>
        private void ClearSalesData()
        {
            this.SaleNumber = 0;
            this.SaleCountOutputTextBox.Text = this.SaleNumber.ToString();
            this.SalesList.Clear();
        }

        /// <summary>
        /// Reset form state.
        /// </summary>
        private void ResetFormState()
        {
            this.ResetDatasource();
            this.RepNameTextBox.Clear();
            this.SaleAmtTextBox.Clear();
            this.HighLowTextBox.Clear();
            this.RepNameTextBox.Focus();
        }

        /// <summary>
        /// Close this form.
        /// </summary>
        /// <param name="sender">ExitButton object</param>
        /// <param name="e">ExitButton EventArgs</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}