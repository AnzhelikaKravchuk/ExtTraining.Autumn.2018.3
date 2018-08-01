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
            RandomBytesFileGenerator bg = new RandomBytesFileGenerator();
            bg.GenerateFiles(5, 20);
            RandomCharsFileGenerator cg = new RandomCharsFileGenerator();
            cg.GenerateFiles(10, 100);
        }
    }
}
