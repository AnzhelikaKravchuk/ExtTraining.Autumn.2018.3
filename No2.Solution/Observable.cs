using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
     /// <summary>
     /// Base class for Bank and Broker. Class contains method, which calls methods subscribed on event NewMarket.
     /// </summary>
     public class Observable
     {
          public virtual void Register(IObserver observer) { }
          public virtual void Unregister(IObserver observer) { }
          public delegate void NewMarketEventHandler(object stocksInfo);
          public event NewMarketEventHandler NewMarket;

          protected void OnNewMarket(object stocksInfo)
          {
               NewMarket?.Invoke(stocksInfo);
          }
     }
}
