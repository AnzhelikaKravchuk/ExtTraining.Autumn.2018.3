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
            Generator randomBytes = new RandomBytesGenerator();
            Generator randomChars = new RandomCharGenerator();
            Saver saver = new Saver();

            saver.Save("Files with random chars", randomBytes.GenerateBytes(1, 10));
        }
    }
}
