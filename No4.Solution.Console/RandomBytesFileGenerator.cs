using System;
using System.IO;
using No4.Solution;

namespace No4
{
    public class RandomBytesFileGenerator : IRandomFileGenerator
    {
        private static readonly  Lazy<RandomBytesFileGenerator> LazyFileGenerator = 
            new Lazy<RandomBytesFileGenerator>(() => new RandomBytesFileGenerator());

        public static RandomBytesFileGenerator Instance => LazyFileGenerator.Value;

        private RandomBytesFileGenerator()
        {
        }
        
        public string WorkingDirectory => "Files with random bytes";

        public string FileExtension => ".bytes";

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        private byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}