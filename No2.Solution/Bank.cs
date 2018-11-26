using System;

namespace No2
{
    public class Bank 
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            Name = name;
        }

        public void Update(object sender, StockInfo info)
        {
            var stockInfo = info;

            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }

        public void Register(Stock stock)
        {
            stock.UpdateStockMarket += Update;
        }

        public void Unregister(Stock stock)
        {
            stock.UpdateStockMarket -= Update;
        }
    }
}
