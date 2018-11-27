using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker
    {
        private StockEventArgs currentCurrency;
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Register(Stock data)
        {
            data.CurrencyChanged += Message;
        }

        public void Unregister(Stock data)
        {
            data.CurrencyChanged -= Message;
        }

        private void Message(object sender, StockEventArgs eventArgs)
        {
            currentCurrency = eventArgs ?? throw new ArgumentNullException($"Incorrect data of {nameof(eventArgs)}");
            Console.WriteLine("Broker report message:");
            Console.WriteLine("Usd = {0}, Euro = {1}\n", eventArgs.USD, eventArgs.Euro);
        }
    }
}
