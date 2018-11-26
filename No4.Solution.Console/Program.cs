using System;
using System.IO;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
			var randomBytesFileGenerator = new RandomBytesFileGenerator();
			randomBytesFileGenerator.GenerateFiles(1, 50);

			var randomCharsFileGenerator = new RandomCharsFileGenerator();
			randomBytesFileGenerator.GenerateFiles(1, 50);
    }
}
