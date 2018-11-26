using System;
using System.Collections.Generic;

namespace No2.Solution
{
    public class Stock : IObservable
    {
        public event EventHandler<MarketEventArgs> Market;

        public void Work()
        {
            Random rnd = new Random();
            OnMarket(new MarketEventArgs(rnd.Next(20, 40), rnd.Next(30, 50)));
        }

        private void OnMarket(MarketEventArgs args)
        {
            Market?.Invoke(this, args);
        }
    }
}
