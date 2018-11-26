using System;

namespace No2.Solution
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Registers broker to a stock
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Register(Stock stock)
        {
            stock.StockChanged += Update;
        }

        /// <summary>
        /// Unregisters broker from a stock
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Unregister(Stock stock)
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
                info.USD > 30
                    ? $"Broker {Name} sells dollars; Dollar rate: {info.USD}"
                    : $"Broker {Name} buys dollars; Dollar rate: {info.USD}");
        }
    }
}