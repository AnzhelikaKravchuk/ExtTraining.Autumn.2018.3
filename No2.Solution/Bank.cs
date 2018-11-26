using System;

namespace No2.Solution
{
    public class Bank
    {
        private IStock stock;

        public string Name { get; set; }

        public Bank(string name, IStock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.StockEvent += Update;
        }

        public void Update(object sender, StockEventArgs e)
        {
            var stockInfo = e.Info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
