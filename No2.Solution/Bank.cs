using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name, StockInfoManager manager)
        {
            this.Name = name;
            Register(manager);
        }

        public void GetNewStockInfo(Object sender, StockInfoEventArgs stockInfo)
        {
            Console.WriteLine(
                stockInfo.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{stockInfo.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {stockInfo.Euro}");
        }

        public void Register(StockInfoManager manager)
        {
            manager.StockInfo += GetNewStockInfo;
        }

        public void Unregister(StockInfoManager manager)
        {
            manager.StockInfo -= GetNewStockInfo;
        }
    }
}
