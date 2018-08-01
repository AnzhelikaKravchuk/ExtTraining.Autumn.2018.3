using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesGenerator : Generator
    {
        protected override byte[] GenerateFile(int length)
        {
            var random = new Random();

            var file = new byte[length];

            random.NextBytes(file);

            return file;
        }
    }
}
