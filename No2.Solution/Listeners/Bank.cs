using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Listeners
{
    public class Bank
    {
        public string Name { get; set; }
        private Stock stock;

        public Bank(string name, Stock stock)
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
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }
    }
}
