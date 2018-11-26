using System;

namespace No2.Solution
{
    public class Broker
    {
        private IStock stock;

        public string Name { get; set; }

        public Broker(string name, IStock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.StockEvent += Update;
        }

        public void Update(object sender, StockEventArgs e)
        {
            StockInfo stockInfo = e.Info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade()
        {
            stock.StockEvent -= Update;
            stock = null;
        }
    }
}
