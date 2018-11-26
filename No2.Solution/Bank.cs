using System;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Registers bank to a stock
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Register(Stock stock)
        {
            stock.StockChanged += Update;
        }

        /// <summary>
        /// Unregisters bank from a stock
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Unegister(Stock stock)
        {
            stock.StockChanged -= Update;
        }

        /// <summary>
        /// Event handler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="info">Stock info</param>
        public void Update(object sender, StockInfo info)
        {
            Console.WriteLine(
                info.Euro > 40
                    ? $"Bank {Name} sells euros; Euro rate:{info.Euro}"
                    : $"Bank {Name} is buying euros; Euro rate: {info.Euro}");
        }
    }
}
