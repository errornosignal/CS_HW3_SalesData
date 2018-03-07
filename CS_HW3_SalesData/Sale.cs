namespace CS_HW3_SalesData
{
    /// <summary>
    /// Sale class
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="repName">Name of salesperson as astring</param>
        /// <param name="saleAmt">Amount of sale as a decimal</param>
        public Sale(string repName, decimal saleAmt)
        {
            this.RepName = repName;
            this.SaleAmt = saleAmt;
        }

        /// <summary>
        /// Gets RepName property.
        /// </summary>
        private string RepName { get; }

        /// <summary>
        /// Gets SaleAmt property.
        /// </summary>
        public decimal SaleAmt { get; }

        /// <summary>
        /// Overrides System.Obeject method for custom object property output.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return RepName + " " + $"{SaleAmt:C}";
        }
    }
}