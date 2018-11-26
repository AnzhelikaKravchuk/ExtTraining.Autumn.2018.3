using System;
using System.IO;

/**
 * Был выделен интерфейс IFileGenerator, который определяет метод GenerateFiles.
 * Классы, реализующие данный интерфейс должны сами определить логику генерации файлов.
 * Т.к. классы генерации файлов имели много общего кода, было принято решение вынести их
 * в родительский абстрактный класс, который имплементирует шаблонный метод генерации файлом.
 * Реализация генерации конкретного содержимого этих файлов была возложена на производные классы.
 */

namespace No4.Solution
{
    public abstract class AbstractFileGenerator : IFileGenerator
    {
        public string WorkingDirectory { get;  protected set; }

        public string FileExtension { get; protected set; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }
        
        private void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

        protected abstract byte[] GenerateFileContent(int contentLength);
    }
}