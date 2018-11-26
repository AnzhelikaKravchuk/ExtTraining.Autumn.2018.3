using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public RandomBytesFileGenerator()
        {
            WorkingDirectory = "Files with random bytes";
            FileExtension = ".bytes";
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
