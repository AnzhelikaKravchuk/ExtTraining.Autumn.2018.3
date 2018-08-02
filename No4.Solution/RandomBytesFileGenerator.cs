using System;
using System.IO;

namespace No4
{
    public class RandomBytesFileGenerator : RandomFilesGenerator
    {
        public RandomBytesFileGenerator(string directory)
        {
            this.WorkingDirectory = directory;
            this.FileExtension = ".bytes";
        }
        
        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        protected override void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}