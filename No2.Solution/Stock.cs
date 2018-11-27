using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        public delegate void CurrencyChangeEventHandler(object sender, StockInfoEventArgs args);
        public event CurrencyChangeEventHandler CurrencyChange;

        public void Market()
        {
            Random rnd = new Random();
            StockInfoEventArgs newStockInfo = new StockInfoEventArgs(rnd.Next(30, 50), rnd.Next(20, 40));

            OnCurrencyChange(this, newStockInfo);
        }

        protected virtual void OnCurrencyChange(object sender, StockInfoEventArgs args)
        {
            if (CurrencyChange != null)
            {
                CurrencyChange.Invoke(sender, args);
            }
        }
    }
}
