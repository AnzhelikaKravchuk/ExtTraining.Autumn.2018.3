using System;

namespace No2.Solution
{
	public class Stock
	{
		private StockInfo stocksInfo;

		public event EventHandler<MarketEventArgs> stockMarket;


		public Stock()
		{
			stocksInfo = new StockInfo();
		}

		public void Market()
		{
			Random rnd = new Random();
			stocksInfo.USD = rnd.Next(20, 40);
			stocksInfo.Euro = rnd.Next(30, 50);

			stockMarket?.Invoke(this, new MarketEventArgs(stocksInfo));
		}
	}
}
