using System;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name, Stock stock)
        {
            this.Name = name;
            this.Register(stock);
        }

        public void Register(Stock stock) => stock.Update += HandlerUpdate;

        public void Unregister(Stock stock) => stock.Update -= HandlerUpdate;
        
        public void HandlerUpdate(object sender, StockInfo info)
        {
            Console.WriteLine(
                info.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{info.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {info.Euro}");
        }
    }
}
