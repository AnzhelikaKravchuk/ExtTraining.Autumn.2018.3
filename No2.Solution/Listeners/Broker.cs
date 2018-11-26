using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Listeners
{
    public class Broker
    {
        public string Name { get; set; }
        private Stock stock;

        public Broker(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
            stock.newDataInfo += ReportNewData;
        }

        public void ReportNewData(object sender, EventArgs eventArgs)
        {
            Update(eventArgs);
        }

        protected virtual void Update(EventArgs info)
        {
            var stockInfo = (StockEventArgs)info;

            Console.WriteLine(
                stockInfo.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {stockInfo.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {stockInfo.USD}");
        }

        public void StopTrade()
        {
            stock.newDataInfo -= ReportNewData;
            stock = null;
        }
    }
}
