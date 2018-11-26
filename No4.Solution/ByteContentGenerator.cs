using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class ByteContentGenerator : IContentGenerator
    {
        public byte[] Generate(int length)
        {
            if (length < 1)
                throw new ArgumentException("Length can't be less than 1 byte");

            var random = new Random();
            var fileContent = new byte[length];
            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
