using System;

namespace No2.Solution
{
    /// <summary>
    /// Class contains method Update, which will called when event NewMarket will happen. 
    /// </summary>
    public class Bank : IObserver
    {
        private Observable stock;

        public string Name { get; set; }

        public Bank(string name, Observable observable)
        {
            this.Name = name;
            stock = observable;
            stock.Register(this);
            stock.NewMarket += Update;
        }

        public void Update(object info)
        {
            var stockInfo = (StockInfo)info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
