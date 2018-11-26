using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            stock.CurrencyChange += this.Update;
        }

        public void Unregister(Stock stock)
        {
            stock.CurrencyChange -= this.Update;
        }

        public void Update(object sender, StockInfoEventArgs info)
        {
            var stockInfo = (StockInfoEventArgs)info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
