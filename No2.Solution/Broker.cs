using System;

namespace No2.Solution
{
    public class Broker : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Broker(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this.Update);
        }

        public void Update(object sender, StockInfo si)
        {
            Console.WriteLine(
                si.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {si.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {si.USD}");
        }

        public void StopTrade()
        {
            stock.Unregister(this.Update);
            stock = null;
        }
    }
}
