using System;
using System.Collections.Generic;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RandomFileGenerator> fileGenerators = new List<RandomFileGenerator>();
            fileGenerators.Add(new RandomCharsFileGenerator(Environment.CurrentDirectory));
            fileGenerators.Add(new RandomBytesFileGenerator(Environment.CurrentDirectory));
            foreach (var item in fileGenerators)
            {
                item.GenerateFiles(1, 25);
            }
        }
    }
}
