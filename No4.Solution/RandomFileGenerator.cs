using System;
using System.IO;

namespace No4.Solution
{
    public abstract class RandomFileGenerator
    {
        public virtual string WorkingDirectory { get; protected set; }
        public virtual string FileExtension { get; protected set; }

        // Шаблонный метод
        public void GenerateFiles(int filesCount, int contentLength)
        {
            if (!IsValid(filesCount) || !IsValid(contentLength))
            {
                throw new ArgumentException("Arguments must be grater than 0");
            }

            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);
                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";
                WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        // Метод, определяемый в наследниках
        protected abstract byte[] GenerateFileContent(int contentLength);

        protected void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

        private bool IsValid(int value) => value >= 0;
    }
}