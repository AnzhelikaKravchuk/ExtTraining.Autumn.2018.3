using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            stock.CurrencyChange += this.Update;
        }

        public void Unregister(Stock stock)
        {
            stock.CurrencyChange -= this.Update;
        }

        public void Update(object sender, StockInfoEventArgs info)
        {
            Console.WriteLine(
                info.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {info.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {info.USD}");
        }
    }
}
