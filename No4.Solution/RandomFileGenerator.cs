using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//выделили абстракцию 
// изабвляясь от копипаста вынесли общие методы и поля ( обязательные) в абстрактный класс
// с помощью шаблонного метода задали стратегию генерирования контента файла
namespace No4.Solution
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class RandomFileGenerator
    {
        #region Private fields
        private string workingDirectory;
        private string fileExtension;
        #endregion

        public string WorkingDirectory { get => workingDirectory; set => workingDirectory = value; }
        public string FileExtension { get => fileExtension; set => fileExtension = value; }

        public RandomFileGenerator(string workingDirectory,string fileExtension)
        {
            this.workingDirectory = workingDirectory;
            this.fileExtension = fileExtension;
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

        protected void WriteBytesToFile(string fileName, byte[] content)
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
