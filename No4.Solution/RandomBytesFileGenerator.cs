using System;
using System.IO;

namespace No4.Solution
{
    /// <summary>
    /// Generates file with bytes
    /// </summary>
    /// <seealso cref="No4.Solution.FileGenerator" />
    public class RandomBytesFileGenerator : FileGenerator
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