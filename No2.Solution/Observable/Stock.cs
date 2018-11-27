using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        private int measurePeriodSeconds;
        private int intervaMeasurelSeconds;
        private StockEventArgs currentCurrency;

        public Stock(int measurePeriodSeconds, int intervalSeconds)
        {
            currentCurrency = new StockEventArgs();
            this.intervaMeasurelSeconds = intervalSeconds;
            this.measurePeriodSeconds = measurePeriodSeconds;
        }

        public event EventHandler<StockEventArgs> CurrencyChanged = delegate { };

        public void Market()
        {
            for (int i = 0; i < measurePeriodSeconds / intervaMeasurelSeconds; i++)
            {
                Console.WriteLine($"\nNew currency data...\n");
                StockEventArgs newData = GetNewCurrency();
                OnCurrencyChanged(this, newData);
                Console.WriteLine(new string('-', 70));
                Thread.Sleep(intervaMeasurelSeconds * 1000);
            }
        }

        protected virtual void OnCurrencyChanged(object sender, StockEventArgs e)
        {
            CurrencyChanged?.Invoke(this, e);
        }

        private StockEventArgs GetNewCurrency()
        {
            Random random = new Random();
            StockEventArgs newCurrency = new StockEventArgs()
            {
                Euro = random.Next(2, 3),
                USD = random.Next(1, 5),
            };

            return newCurrency;
        }
    }
}
