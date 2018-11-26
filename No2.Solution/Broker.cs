using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        private Stock stock;
        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.UpdateInfo += Update;
        }

        public void Update(object sende, EventArgs eventArgs)
        {
            Update(eventArgs);
        }

        private void Update(object info)
        {
            StockInfoEventArgs stockInfo = (StockInfoEventArgs)info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade()
        {
            stock.UpdateInfo -= Update;
            stock = null;
        }
    }
}
