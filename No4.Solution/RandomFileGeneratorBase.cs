using System;
using System.IO;
namespace No4.Solution
{
    public abstract class RandomFileGeneratorBase
    {
        protected RandomFileGeneratorBase(string workingDirectory, string fileExtension)
        {
            WorkingDirectory = workingDirectory ?? throw new ArgumentNullException(nameof(workingDirectory));
            FileExtension = fileExtension ?? throw new ArgumentNullException(nameof(fileExtension));
        }

        public string WorkingDirectory { get; }

        public string FileExtension { get; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        internal abstract byte[] GenerateFileContent(int contentLength);

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
