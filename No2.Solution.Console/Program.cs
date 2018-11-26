using No2.Solution.Listeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank", stock);
            var broker = new Broker("Broker", stock);

            stock.Market();

            bank.UnRegister();

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
