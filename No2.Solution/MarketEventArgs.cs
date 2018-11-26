using System;

namespace No2.Solution
{
	public class MarketEventArgs : EventArgs
	{
		public StockInfo StockInfo;

		public MarketEventArgs(StockInfo stockInfo)
		{
			StockInfo = stockInfo;
		}
	}
}
