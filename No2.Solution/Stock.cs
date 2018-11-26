using System;
using System.Collections.Generic;
using No2;

namespace No2.Solution
{
    public class Stock : IObservable
    {
        public delegate void Actions(StockInfo ex);
        public event Actions StockEvent;

        private StockInfo stocksInfo;

        private readonly List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
            StockEvent += observer.Update;
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
            StockEvent -= observer.Update;
        }

        public void Notify()
        {
            StockEvent(stocksInfo);
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
