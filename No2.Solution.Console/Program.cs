using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution.Console
{
    /// <summary>
    /// В данной задаче необходимо использовать модель реализации паттерна observer 
    /// возможной в .net. Имеется 1 система генерирующая события (stock) и 
    /// оповещающая всех подписчиков (bank,broker..).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");

            bank.Subscribe(stock);
            broker.Subscribe(stock);

            stock.Market();

            System.Console.ReadLine();
        }
    }
}
