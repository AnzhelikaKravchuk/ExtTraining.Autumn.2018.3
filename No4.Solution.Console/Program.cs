using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No4.Solution.File_generators;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FileGenerator generator = new RandomBytesFileGenerator();
            generator.GenerateFiles(2, 10);
        }
    }
}
