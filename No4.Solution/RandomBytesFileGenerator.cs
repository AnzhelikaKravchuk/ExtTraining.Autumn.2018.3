using System;

namespace No4.Solution
{
    public class RandomBytesFileGenerator: RandomFileGenerator
    {
        public override string WorkingDirectory => "Files with random bytes";
        public override string FileExtension => ".bytes";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();
            var fileContent = new byte[contentLength];
            random.NextBytes(fileContent);

            return fileContent;
        }      
    }
}