using System;
using System.Collections.Generic;

namespace No2
{
    public class Stock : IObservable
    {
        private StockInfo stocksInfo;

        private readonly List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer) => observers.Add(observer);

        public void Unregister(IObserver observer) => observers.Remove(observer);

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stocksInfo);
            }
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
