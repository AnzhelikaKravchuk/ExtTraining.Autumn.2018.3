using static System.Console;

namespace No4.Solution.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var generatorBytes = new RandomBytesFileGenerator();
            var generatorChars = new RandomCharsFileGenerator();

            generatorChars.GenerateFiles(1, 3333);
            generatorBytes.GenerateFiles(1, 3333);

            ReadKey();
        }
    }
}
