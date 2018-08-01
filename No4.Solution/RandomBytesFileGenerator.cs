using System;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGeneratorBase
    {
        private const string DIRECTORY = "Files with random bytes";

        private const string EXTENSION = ".bytes";

        public RandomBytesFileGenerator() : base(DIRECTORY, EXTENSION)
        {
        }

        protected RandomBytesFileGenerator(string workingDirectory = DIRECTORY, string fileExtension = EXTENSION) : base(workingDirectory, fileExtension)
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