using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public abstract class RandomFileGenerator
    {
        public abstract string WorkingDirectory { get; set; }

        public abstract string FileExtension { get; set; }

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
