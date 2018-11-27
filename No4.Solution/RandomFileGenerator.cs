using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomFileGenerator : IRandomFileGenerator
    {
        public string FileExtension { get; }

        public string WorkingDirectory { get; }

        private IWriter _writer;

        private IContentGenerator _contentGenerator;

        public RandomFileGenerator(
            string directory, string extention, IWriter writer, IContentGenerator contentGenerator)
        {
            WorkingDirectory = directory;
            FileExtension = extention;
            _writer = writer;
            _contentGenerator = contentGenerator;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = _contentGenerator.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                _writer.WriteBytesToFile(WorkingDirectory, generatedFileName, generatedFileContent);
            }
        }
    }
}
