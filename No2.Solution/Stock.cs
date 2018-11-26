﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        private StockInfoChangeEventsArgs stockInfo = new StockInfoChangeEventsArgs(0, 0);

        public Stock (StockInfoChangeEventsArgs stockInfo)
        {
            this.stockInfo = stockInfo;
        }

        public event EventHandler<StockInfoChangeEventsArgs> StockInfoChanged = delegate { };

        public void Market()
        {
            Random rnd = new Random();
            stockInfo.USD = rnd.Next(20, 40);
            stockInfo.Euro = rnd.Next(30, 50);
            OnStockInfoChanged(stockInfo);
        }

        protected virtual void OnStockInfoChanged(StockInfoChangeEventsArgs info)
        {
            StockInfoChanged(this, info);
        }
    }
}
