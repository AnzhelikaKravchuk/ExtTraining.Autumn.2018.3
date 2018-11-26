namespace No2.Solution
{
	public interface IStockMarketListener
	{
		void Subscribe(Stock stock);
		void Unsubscribe(Stock stock);
	}
}
