using System.IO;
using static System.Console;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileGenerator1 = new RandomBytesFileGenerator();

            fileGenerator1.GenerateFiles(10, 100);
            
            var fileGenerator2 = new RandomCharsFileGenerator();

            fileGenerator2.GenerateFiles(15, 40);

            var files1 = Directory.GetFiles(fileGenerator1.WorkingDirectory);

            var files2 = Directory.GetFiles(fileGenerator1.WorkingDirectory);

            WriteLine($"First repository\n{string.Join("\n",files1)}");
            WriteLine($"Second repository\n{string.Join("\n", files2)}");

            Read();
        }
    }
}
