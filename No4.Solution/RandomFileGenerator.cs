using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public abstract class RandomFileGenerator
    {
        public string WorkingDirectory { get; protected set; }

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

        protected abstract byte[] GenerateFileContent(int contentLength);

        protected abstract void WriteBytesToFile(string fileName, byte[] content);
    }
}
