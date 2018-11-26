using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    /*
     * Выделен базовый абстрактный класс, содержащий общие методы.
     * Логика генерации случаного заполнения файлов реализуется в классах-наследниках.
     * Используется паттерн "Шаблонный метод"
     */
    public abstract class RandomFileGenerator
    {
        public RandomFileGenerator(string workingDirectory, string fileExtension)
        {
            if (string.IsNullOrWhiteSpace(workingDirectory) || string.IsNullOrWhiteSpace(fileExtension))
            {
                throw new ArgumentException($"{nameof(workingDirectory)} and {nameof(fileExtension)} need to be not empty.");
            }

            WorkingDirectory = workingDirectory;
            FileExtension = fileExtension;
        }

        public string WorkingDirectory { get; private set; }

        public string FileExtension { get; private set; }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        public abstract byte[] GenerateFileContent(int contentLength);

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
