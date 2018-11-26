using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        private StockInfoEventArgs stockInfo;
        public event EventHandler<StockInfoEventArgs> UpdateInfo = delegate { };

        public Stock()
        {
            stockInfo = new StockInfoEventArgs();
        }

        protected virtual void OnUpdateInfo(object sender, EventArgs eventArgs)
        {
            UpdateInfo(this, stockInfo);
        }

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(20, 40);
            stockInfo.Euro = rnd.Next(30, 50);
            OnUpdateInfo(this, stockInfo);
        }
    }
}
