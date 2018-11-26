using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock
    {
        private StockInfo stocksInfo;

        public event EventHandler<StockInfo> Update = delegate { };

        private void OnUpdate(StockInfo info)
        {
            Update(this, info);
        }

        public Stock()
        {
            stocksInfo = new StockInfo();
        }
       
        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnUpdate(stocksInfo);
        }
    }
}
