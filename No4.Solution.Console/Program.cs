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
            new RandomBytesFileGenerator().GenerateFiles(1, 10);
            new RandomCharsFileGenerator().GenerateFiles(1, 10);
            new RandomBytesFileGenerator().GenerateFiles(2, 50);
            new RandomCharsFileGenerator().GenerateFiles(3, 60);
        }
    }
}
