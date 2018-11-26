using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No2.Solution;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new No2.Solution.Bank("Bank", stock);
            var broker = new No2.Solution.Broker("Broker", stock);

            stock.Register(bank);
            stock.Register(broker);
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
