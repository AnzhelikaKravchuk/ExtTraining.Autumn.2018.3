using System;

namespace No2.Solution
{
    /// <summary>
    /// Class imitates work processing of broker
    /// </summary>
    public sealed class Broker
    {
        /// <summary>
        /// Name of broker
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Broker"/>
        /// </summary>
        /// <param name="name">Broker's name</param>
        public Broker(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Subscribes current instance of broker of stock's events
        /// </summary>
        /// <param name="stock"></param>
        public void Subscribe(Stock stock) => stock.StockChanged += this.NotifyBroker;

        private void NotifyBroker(object sender,StockInfoEventArgs stockInfo)
        {
            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        /// <summary>
        /// Unsubscribes current instance of broker of stock's events
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Unsubscribe(Stock stock) => stock.StockChanged += this.NotifyBroker;
    }
}
