using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {
        public Bank(string name, Stock stock)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            stock.StockInfoChanged += Stake;
        }

        public string Name { get; }

        public void Stake(object sender, StockInfoChangeEventsArgs stockInfo)
        {
            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
