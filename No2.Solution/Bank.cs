using System;

namespace No2.Solution
{
    public class Bank : IObserver
    {
        private IObservable stock;

        public string Name { get; set; }

        public Bank(string name, IObservable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Market += Update;
        }

        public void Update(object sender, MarketEventArgs e)
        {
            Console.WriteLine(
                e.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{e.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {e.Euro}");
        }
    }
}
