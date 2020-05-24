using No2.Solution.Entities;
using No2.Solution.Event;
using No2.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Service
{
    public class Stock : IObservable
    {
        private StockInfo stockInfo;
        private readonly List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            stockInfo = new StockInfo();
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stockInfo);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(20, 40);
            stockInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
