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
            RandomFileGenerator rbfg = new RandomBytesFileGenerator();
            rbfg.GenerateFiles(10,15);
            RandomFileGenerator rcfg = new RandomCharsFileGenerator();
            rcfg.GenerateFiles(20,40);
        }
    }
}
