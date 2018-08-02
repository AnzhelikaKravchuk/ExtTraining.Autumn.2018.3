using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            RandomCharGenerator Char = new RandomCharGenerator();
            RandomBytesGenerator Bytes = new RandomBytesGenerator();
            Char.GenerateFiles(2, 3);
            Bytes.GenerateFiles(2,3);
        }
    }
}
