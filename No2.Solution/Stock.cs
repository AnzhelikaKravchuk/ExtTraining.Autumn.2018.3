using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        private StockInfoEventArgs stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfoEventArgs();
        }

        public event EventHandler<StockInfoEventArgs> CurrencyChange = delegate { };

        protected virtual void OnCurrencyChange(StockInfoEventArgs info) => CurrencyChange?.Invoke(this, info);

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnCurrencyChange(stocksInfo);
        }
    }
}
