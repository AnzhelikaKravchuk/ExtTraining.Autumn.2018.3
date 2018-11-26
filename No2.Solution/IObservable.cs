namespace No2.Solution
{
    public interface IObservable
    {
        void Register(Stock.StockChangeEventHadler handler);
        void Unregister(Stock.StockChangeEventHadler handler);
        void OnMarketChange(object sener, StockInfo e);
    }
}
