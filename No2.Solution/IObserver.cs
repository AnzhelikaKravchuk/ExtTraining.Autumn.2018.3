namespace No2.Solution
{
    public interface IObserver
    {
        void Update(object sender, MarketEventArgs e);
    }
}
