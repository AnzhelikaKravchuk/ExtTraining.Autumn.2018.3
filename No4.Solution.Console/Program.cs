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
            List<RandomFilesGenerator> generators = new List<RandomFilesGenerator>();

            generators.Add(new RandomCharsFileGenerator(Environment.CurrentDirectory));
            generators.Add(new RandomBytesFileGenerator(Environment.CurrentDirectory));

            foreach (var item in generators)
            {
                item.GenerateFiles(1, 25);
            }
        }
    }
}
