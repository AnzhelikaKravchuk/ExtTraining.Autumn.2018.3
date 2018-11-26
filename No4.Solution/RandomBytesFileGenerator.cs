using System;
using System.IO;
using No4.Solution;

namespace No4
{
    public class RandomBytesFileGenerator : AbstractFileGenerator
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