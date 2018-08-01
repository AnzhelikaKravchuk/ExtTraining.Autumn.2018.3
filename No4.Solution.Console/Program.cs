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
            FileGenerator fileChar = new RandomCharFile();
            FileGenerator fileByte = new RandomBytesFile();

            fileChar.GenerateFiles(1, 15);
            fileByte.GenerateFiles(1, 15);
        }
    }
}
