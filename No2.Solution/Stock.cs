using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    /// <summary>
    /// Observable class.
    /// </summary>
    public class Stock
    {
        private StockEventArgs stocksInfo;

        public event EventHandler<StockEventArgs> newDataInfo = delegate { };

        /// <summary>
        /// Constructor to create object of class.
        /// </summary>
        public Stock()
        {
            stocksInfo = new StockEventArgs();
        }

        protected virtual void OnNewDataInfo(object sender, EventArgs e)
        {
            newDataInfo(this, stocksInfo);
        }

        /// <summary>
        /// Method to simulate market.
        /// </summary>
        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnNewDataInfo(this, stocksInfo);
        }
    }
}
