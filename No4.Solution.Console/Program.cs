using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator.GenerateFiles(5, 100, "Test", ".txt", new ByteContentGenerator());

            System.Console.Read();
        }
    }
}
