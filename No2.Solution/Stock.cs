using System;
using System.Collections.Generic;

namespace No2.Solution
{
    /// <summary>
    /// Class imitates work processing of stock
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Provides events of changing stock
        /// </summary>
        public event EventHandler<StockInfoEventArgs> StockChanged = delegate { };

        private void OnStockChanged(object sender,StockInfoEventArgs eventArgs)
        {
            this.StockChanged(this, eventArgs);
        }

        /// <summary>
        /// Initiates change of stock info
        /// </summary>
        public void Market()
        {
            Random rnd = new Random();

            StockInfoEventArgs stockInfoEventArgs = new StockInfoEventArgs();

            stockInfoEventArgs.USD = rnd.Next(20, 40);
            stockInfoEventArgs.Euro = rnd.Next(30, 50);

            this.OnStockChanged(this,stockInfoEventArgs);
        }
    }
}
