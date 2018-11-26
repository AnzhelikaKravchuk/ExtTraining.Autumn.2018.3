using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new StockInfoManager();

            var bank = new Bank("Bank 1", manager);
            var broker = new Broker("Broker 1", manager);

            var stock = new Stock(manager);

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
