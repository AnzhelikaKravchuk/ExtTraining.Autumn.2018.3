using System;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : BaseFileGenerator
    {
        public RandomBytesFileGenerator(
            string workingDirectory,
            string fileExtension)
            : base(workingDirectory, fileExtension)
        {
        }

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}