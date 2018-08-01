using System;
using System.IO;

namespace No4.Solution
{
    public abstract class RandomFileGenerator
    {
        protected RandomFileGenerator(string fileExtension, string workingDirectory)
        {
            this.FileExtension = fileExtension;
            this.WorkingDirectory = workingDirectory;
        }

        public string FileExtension { get; }

        public string WorkingDirectory { get; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(this.WorkingDirectory))
            {
                Directory.CreateDirectory(this.WorkingDirectory);
            }

            File.WriteAllBytes($"{this.WorkingDirectory}//{fileName}", content);
        }
    }
}