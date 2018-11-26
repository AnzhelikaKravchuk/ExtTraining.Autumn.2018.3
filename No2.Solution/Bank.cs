using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank : IObserver
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            this.Name = name;           
        }

        public void StartTrade(Stock stock)
        {
            stock.CurrencyChange += Update;
        }
        
        public void StopTrade(Stock stock)
        {
            stock.CurrencyChange -= Update;
        }        

        public void Update(object sender, StockInfoEventArgs args)
        {            
            Console.WriteLine(
                args.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{args.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {args.Euro}");
        }
    }
}
