using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
     /// <summary>
     /// Class contains method Update, which will called when event NewMarket will happen. 
     /// </summary>
     public class Broker : IObserver
     {
          private Observable stock;

          public string Name { get; set; }

          public Broker(string name, Observable observable)
          {
               this.Name = name;
               stock = observable;
               stock.Register(this);
               stock.NewMarket += Update;
          }

          public void Update(object info)
          {
               StockInfo stockInfo = (StockInfo)info;

               Console.WriteLine(
                   stockInfo.USD > 30
                       ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                       : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
          }

          public void StopTrade()
          {
               stock.Unregister(this);
               stock = null;
          }
     }
}
