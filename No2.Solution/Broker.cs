using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker : IObserver
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void StartTrade(Stock stock)
        {
            stock.CurrencyChange += Update;
        }

        public void StopTrade(Stock stock)
        {
            stock.CurrencyChange -= Update;
        }

        public void Update(object sender, StockInfoEventArgs args)
        {
            Console.WriteLine(
                args.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {args.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {args.USD}");
        }
    }
}
