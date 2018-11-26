using System;

namespace No2.Solution
{
    /// <summary>
    /// Class imitates bank work processing
    /// </summary>
    public sealed class Bank
    {
        /// <summary>
        /// Gets and sets current name of bank
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Bank"/>
        /// </summary>
        /// <param name="name">Name of bank</param>
        public Bank(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Subscribes current instance of bank to <paramref name="stock"/> events
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Subscribe(Stock stock) => stock.StockChanged += this.NotifyBank;

        private void NotifyBank(object sender, StockInfoEventArgs stockInfoEventArgs)
        {
            Console.WriteLine(
                stockInfoEventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfoEventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfoEventArgs.Euro}");
        }

        /// <summary>
        /// Unsubscribes current instance of bank of stock's events
        /// </summary>
        /// <param name="stock">Stock</param>
        public void Unsubscribe(Stock stock) => stock.StockChanged += this.NotifyBank;
    }
}
