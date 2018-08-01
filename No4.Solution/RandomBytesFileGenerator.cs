using System;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}