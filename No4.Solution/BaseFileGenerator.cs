using System;
using System.IO;

namespace No4.Solution
{
    public abstract class BaseFileGenerator
    {
        private readonly string _workingDirectory;
        private readonly string _fileExtension;

        public BaseFileGenerator(
            string workingDirectory,
            string fileExtension)
        {
            _workingDirectory = workingDirectory;
            _fileExtension = fileExtension;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this._fileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        internal abstract byte[] GenerateFileContent(int contentLength);

        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(_workingDirectory))
            {
                Directory.CreateDirectory(_workingDirectory);
            }

            File.WriteAllBytes($"{_workingDirectory}//{fileName}", content);
        }
    }
}