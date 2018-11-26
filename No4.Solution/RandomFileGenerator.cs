using System;
using System.IO;

namespace No4.Solution
{
    /*
     * Мы добавляем в решение абстрактный класс, в который добавляем один абстрактный метод, отвечающий за генерацию контента, остальные методы должны выполняться
     * одинаково, несмотря на тип информации, поэтому отдаем предпочтение именно классу, а не интерфейсу.
     */
    public abstract class RandomFileGenerator
    {
        public readonly string WorkingDirectory;

        public readonly string FileExtension;

        protected RandomFileGenerator(string workingDirectory, string fileExtension)
        {
            if (string.IsNullOrWhiteSpace(workingDirectory))
            {
                throw new ArgumentException(nameof(workingDirectory) + "must not be null, empty or whitespace.");
            }

            if (string.IsNullOrWhiteSpace(workingDirectory))
            {
                throw new ArgumentException(nameof(fileExtension) + "must not be null, empty or whitespace.");
            }

            WorkingDirectory = workingDirectory;
            FileExtension = fileExtension;
        }

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
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}
