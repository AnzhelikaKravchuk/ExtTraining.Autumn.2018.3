using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        public Broker (string name, Stock stock)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            stock.StockInfoChanged += Stake;
        }

        public string Name { get; }

        public void StopTrade(Stock stock)
        {
            stock.StockInfoChanged -= Stake;
        }

        public void Stake(object sender, StockInfoChangeEventsArgs stockInfo)
        {  
            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }
    }
}
