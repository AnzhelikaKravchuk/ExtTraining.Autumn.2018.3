using System;

namespace No2.Solution
{
    public class MarketEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }

        public MarketEventArgs(int usd, int euro)
        {
            USD = usd;
            Euro = euro;
        }
    }
}
