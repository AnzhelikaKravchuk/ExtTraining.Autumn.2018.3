using static System.Console;

namespace No2.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();

            var bank = new Bank("Bank");
            var broker = new Broker("Broker");

            stock.Changed += bank.Update;
            stock.Changed += broker.Update;

            stock.Market();

            ReadLine();
        }
    }
}
