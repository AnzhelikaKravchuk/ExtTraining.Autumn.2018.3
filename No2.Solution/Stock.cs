using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock : IObservable
    {
        private delegate void StocksHandler(StockInfo info);

        private event StocksHandler Notifying;

        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        /// <summary>
        /// Add observer to delegate list for notify
        /// </summary>
        /// <param name="observer"></param>
        public void Register(IObserver observer) => Notifying += observer.Update;

        /// <summary>
        /// Remove observer form delegate list for notify
        /// </summary>
        public void Unregister(IObserver observer) => Notifying -= observer.Update;

        public void Notify()
        {
            Notifying(stocksInfo);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
