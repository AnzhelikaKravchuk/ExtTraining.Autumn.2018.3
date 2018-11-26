using System;

namespace No2.Solution
{
    public interface IObservable
    {
        event EventHandler<MarketEventArgs> Market;
    }
}
