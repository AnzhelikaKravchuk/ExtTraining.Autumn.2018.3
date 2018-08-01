using System;
using System.IO;

namespace No4
{
    public class RandomBytesFileGenerator: IRandomFileGenerator
    {
        protected override string WorkingDirectory => "Files with random bytes";

        protected override string FileExtension => ".bytes";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

       
    }
}