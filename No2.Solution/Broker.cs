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
            stock.Market += Update;
        }

        public void Update(object sender, MarketEventArgs e)
        {
            Console.WriteLine(
                e.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {e.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {e.USD}");
        }

        public void StopTrade()
        {
            stock.Market -= Update;
            stock = null;
        }
    }
}
