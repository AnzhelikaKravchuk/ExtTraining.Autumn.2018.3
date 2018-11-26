using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock : IObservable
    {
        private StockInfo stocksInfo;
        public event StockChangeEventHadler StockChanged;
        public delegate void StockChangeEventHadler(object sender, StockInfo e);

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Register(StockChangeEventHadler handler)
        {
            StockChanged += handler;
        }

        public void OnMarketChanged(object sender, StockInfo e)
        {
            StockChanged?.Invoke(this, e);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnMarketChanged(this, stocksInfo);
        }

        public void Unregister(StockChangeEventHadler handler)
        {
            throw new NotImplementedException();
        }

        public void OnMarketChange(object sener, StockInfo e)
        {
            throw new NotImplementedException();
        }
    }
}
