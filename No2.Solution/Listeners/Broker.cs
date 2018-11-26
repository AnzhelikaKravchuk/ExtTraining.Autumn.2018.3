using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Listeners
{
    /// <summary>
    /// Class observer.
    /// </summary>
    public class Broker
    {
        public string Name { get; set; }

        private Stock stock;

        /// <summary>
        /// Method constructor of object.
        /// </summary>
        /// <param name="name">
        /// Name of bank.
        /// </param>
        /// <param name="stock">
        /// Object of observable class.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="name"/> or <paramref name="stock"/> is null.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="name"/> is empty.
        /// </exception>
        public Broker(string name, Stock stock)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name) + ", name of bank is null.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name) + " name of bank is empty.");
            }

            if (stock is null)
            {
                throw new ArgumentNullException(nameof(stock) + ", object of Stock is null.");
            }

            this.Name = name;
            this.stock = stock;
            stock.newDataInfo += ReportNewData;
        }

        /// <summary>
        /// Method to event bank about new data.
        /// </summary>
        /// <param name="sender">
        /// Object of sender class.
        /// </param>
        /// <param name="eventArgs">
        /// Object with information about event.
        /// </param>
        public void ReportNewData(object sender, EventArgs eventArgs)
        {
            Update(eventArgs);
        }

        /// <summary>
        /// Method to stop get information about events.
        /// </summary>
        public void StopTrade()
        {
            stock.newDataInfo -= ReportNewData;
            stock = null;
        }

        protected virtual void Update(EventArgs info)
        {
            var stockInfo = (StockEventArgs)info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }
    }
}
