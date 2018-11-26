using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock
    {
        /// <summary>
        /// Event whick raises when stock changed
        /// </summary>
        public EventHandler<StockInfo> StockChanged;

        public Stock() { }

        /// <summary>
        /// Invokes all event handlers if they exist
        /// </summary>
        /// <param name="info"></param>
        public void OnStockChanged(StockInfo info)
        {
            StockChanged?.Invoke(this, info);
        }

        /// <summary>
        /// Raises event
        /// </summary>
        public void Market()
        {
            Random rnd = new Random();
 
            OnStockChanged(new StockInfo() { USD = rnd.Next(20, 40), Euro = rnd.Next(30, 50) });
        }
    }
}
