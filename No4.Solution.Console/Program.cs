using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var charsGenerator = new RandomCharsFileGenerator();
            var bytesGenerator = new RandomBytesFileGenerator();

            charsGenerator.GenerateFiles(1, 100);
            bytesGenerator.GenerateFiles(1, 200);

            System.Console.ReadKey();
        }
    }
}
