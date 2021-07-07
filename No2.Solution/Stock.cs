using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
     /// <summary>
     /// Instead of the Notify method use event in base class.
     /// </summary>
     public class Stock : Observable
     {
          private StockInfo stocksInfo;

          private readonly List<IObserver> observers;

          public Stock()
          {
               observers = new List<IObserver>();
               stocksInfo = new StockInfo();
          }

          public override void Register(IObserver observer) => observers.Add(observer);

          public override void Unregister(IObserver observer) => observers.Remove(observer);

          public void Market()
          {
               Random rnd = new Random();
               stocksInfo.USD = rnd.Next(20, 40);
               stocksInfo.Euro = rnd.Next(30, 50);
               OnNewMarket(stocksInfo);
          }
          
     }
}
