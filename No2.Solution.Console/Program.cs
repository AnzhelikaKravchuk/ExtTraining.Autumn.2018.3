﻿using System;
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
            var stock = new Stock();

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");

            bank.Register(stock);
            broker.Register(stock);

            stock.Market();

            bank.Unegister(stock);

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
