using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        StockInfoManager manager;

        public Stock(StockInfoManager manager)
        {
            this.manager = manager;
        }

        public void Market()
        {
            Random rnd = new Random();
            int usd = rnd.Next(20, 40);
            int euro = rnd.Next(30, 50);
            var market = new Tuple<int, int>(usd, euro);

            manager.SimulateNewStockInfo(market);
        }
    }
}
