using System;
using System.Timers;
using System.Collections.Generic;

namespace No2
{
    public class Stock
    {
        private Timer timer;

        #region Using Singleton pattern

        private static readonly Lazy<Stock> instance =
            new Lazy<Stock>(() => new Stock(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        public static Stock Instance { get => instance.Value; }

        private Stock() { }

        #endregion

        private StockInfo stocksInfo;

        public event EventHandler<StockInfo> UpdateStockMarket = delegate { };

        protected virtual void OnUpdateStockMarket(StockInfo e)
        {
            UpdateStockMarket(this, e);
        }

        public void StartWorking()
        {
            timer = new Timer(2000);
            timer.Elapsed += (source, e) => Market();
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public void StopWorking()
        {
            timer.Stop();
            timer.Dispose();
        }

        private void Market()
        {
            stocksInfo = new StockInfo();
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            OnUpdateStockMarket(stocksInfo);
        }
    }
}
