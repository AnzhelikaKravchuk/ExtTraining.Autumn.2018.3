using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
	public class Bank : IStockMarketListener
	{
		public string Name { get; set; }

		public Bank(string name)
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
				marketEventArgs.StockInfo.Euro > 40
					? $"Bank {this.Name} sells euros; Euro rate:{marketEventArgs.StockInfo.Euro}"
					: $"Bank {this.Name} is buying euros; Euro rate: {marketEventArgs.StockInfo.Euro}");
		}
	}
}
