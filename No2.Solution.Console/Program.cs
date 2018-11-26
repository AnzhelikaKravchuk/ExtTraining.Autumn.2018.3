namespace No2.Solution.Console
{
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
