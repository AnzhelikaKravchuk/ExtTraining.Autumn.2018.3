using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock : IStock
    {
        private StockInfo stocksInfo;

        public event StockHandler StockEvent;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        protected void OnMarket(object sender, StockEventArgs e)
        {
            StockEvent?.Invoke(sender, e);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnMarket(this, new StockEventArgs() { Info = stocksInfo });
        }
    }
}
