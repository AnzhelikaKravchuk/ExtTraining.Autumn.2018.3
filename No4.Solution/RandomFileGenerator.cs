using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace No4.Solution
{
    //Все тот же паттерн "Стратегия".
    //Интерфейс для генератора содержимого и имени файла.
    public class RandomFileGenerator
    {
        public string WorkingDirectory { get; set; }
        
        public RandomFileGenerator(IFileContentGenerator contentGenerator, IFileNameGenerator nameGenerator)
        {
            _contentGenerator = contentGenerator;
            _nameGenerator = nameGenerator;
        }

        private IFileContentGenerator _contentGenerator;

        private IFileNameGenerator _nameGenerator;

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = _contentGenerator.Generate(contentLength);

                var generatedFileName = _nameGenerator.Generate();

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
    }
}
