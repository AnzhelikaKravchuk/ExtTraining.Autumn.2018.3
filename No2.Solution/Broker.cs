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

        public Broker(string name, StockInfoManager manager)
        {
            this.Name = name;
            Register(manager);
        }

        public void GetNewStockInfo(Object sender, StockInfoEventArgs stockInfo)
        {
            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade(StockInfoManager manager)
        {
            Unregister(manager);
        }

        public void Register(StockInfoManager manager)
        {
            manager.StockInfo += GetNewStockInfo;
        }

        public void Unregister(StockInfoManager manager)
        {
            manager.StockInfo -= GetNewStockInfo;
        }
    }
}
