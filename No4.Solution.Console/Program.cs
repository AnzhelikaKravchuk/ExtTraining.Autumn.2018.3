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
            RandomFileGenerator byChar = new RandomCharsFileGenerator();
            byChar.GenerateFiles(1, 20);
            RandomFileGenerator byBytes = new RandomBytesFileGenerator();
            byBytes.GenerateFiles(1, 20);
        }
    }
}
