using System;

namespace No2.Solution
{
	public class Broker : IStockMarketListener
	{
		public string Name { get; set; }

		public Broker(string name)
		{
			this.Name = name;
		}

		public void Subscribe(Stock stock)
		{
			stock.stockMarket += PrintInfo;
		}

		public void Unsubscribe(Stock stock)
		{
			stock.stockMarket -= PrintInfo;
		}

		private void PrintInfo(object sender, MarketEventArgs marketEventArgs)
		{
			Console.WriteLine(
				marketEventArgs.StockInfo.USD > 30
					? $"Broker {this.Name} sells dollars; Dollar rate: {marketEventArgs.StockInfo.USD}"
					: $"Broker {this.Name} buys dollars; Dollar rate: {marketEventArgs.StockInfo.USD}");
		}
	}
}
