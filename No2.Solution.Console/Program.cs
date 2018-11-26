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
            var stock = Stock.Instance;

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");

            bank.Register(stock);
            broker.Register(stock);

            stock.StartWorking();

            System.Console.ReadLine();

            stock.StopWorking();


            System.Console.ReadLine();
        }
    }
}
