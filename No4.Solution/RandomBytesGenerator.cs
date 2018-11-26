using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesGenerator : RandomFileGenerator
    {
        public RandomBytesGenerator() : base("Files with random bytes", ".bytes")
        {
        }

        public RandomBytesGenerator(string workingDirectory, string fileExtension) : base(workingDirectory, fileExtension)
        {
        }

        public override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
