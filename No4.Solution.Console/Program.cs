using No4.Solution.Interfaces;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomBytesFileGenerator randomBytesFile = new RandomBytesFileGenerator(@"E:\", ".bytes");

            byte[] array = { 1, 2, 3, 4, 5, 6, 7, 7, 89, 5, 3, 3, 5, 2, 5, 3, 6 };

            randomBytesFile.WriteBytesToFile("log.txt", array);

            System.Console.ReadLine();
        }
    }
}
