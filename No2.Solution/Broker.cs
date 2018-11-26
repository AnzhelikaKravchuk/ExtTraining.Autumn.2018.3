using System;

namespace No2
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            Name = name;
        }

        public void Update(object sender, StockInfo info)
        {
            StockInfo stockInfo = info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void Register(Stock stock)
        {
            stock.UpdateStockMarket += Update;
        }

        public void Unregister(Stock stock)
        {
            stock.UpdateStockMarket -= Update;
        }
    }
}
