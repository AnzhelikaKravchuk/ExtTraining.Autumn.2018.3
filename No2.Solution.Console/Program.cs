using No2.Solution.Entities;
using No2.Solution.Event;
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

            Trade trade = new Trade();
            var stock = new Stock();

            Bank bank = new Bank("Bank-Belarus", stock);
            Broker broker = new Broker("James", stock);

            stock.Register(bank);
            stock.Register(broker);
            stock.Market();

            System.Console.ReadLine();
        }
    }
}
