using System;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.Register(stock);
        }

        public void Register(Stock stock) => stock.Update += HandlerUpdate;

        public void Unregister(Stock stock) => stock.Update -= HandlerUpdate;
        
        public void HandlerUpdate(object sender, StockInfo info)
        {
            Console.WriteLine(
                info.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {info.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {info.USD}");
        }
    }
}
