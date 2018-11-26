using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {     
        public string Name { get; set; }
        private Stock stock;

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.UpdateInfo += Update;
        }

        public void Update(object sende, EventArgs eventArgs)
        {
            Update(eventArgs);
        }

        public void Update(object info)
        {
            var stockInfo = (StockInfoEventArgs)info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
