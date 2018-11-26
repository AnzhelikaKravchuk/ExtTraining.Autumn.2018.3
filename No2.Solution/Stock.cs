using System;

namespace No2.Solution
{
    public class Stock
    {
        private StockInfo _stocksInfo;

        public event EventHandler<StockInfo> Changed = delegate { };

        public void Market()
        {
            var rnd = new Random();

            _stocksInfo = new StockInfo
            {
                Euro = rnd.Next(30, 50),
                USD = rnd.Next(20, 40)
            };

            OnChanged(_stocksInfo);
        }

        protected virtual void OnChanged(StockInfo e)
        {
            Changed(this, e);
        }
    }
}
