using System;

namespace No4.Solution
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