using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class StockInfoManager
    {
        public delegate void StockInfoEventHandler(object sender, StockInfoEventArgs e);

        public event StockInfoEventHandler StockInfo;

        protected virtual void OnNewStockInfo(object sender, StockInfoEventArgs e)
        {
            StockInfo?.Invoke(sender, e);
        }

        public void SimulateNewStockInfo(Tuple<int, int> market)
        {
            OnNewStockInfo(this, new StockInfoEventArgs(market.Item1, market.Item2));
        }
    }
}
