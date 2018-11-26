using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace No4.Solution
{
    /// <summary>
    /// Abstract class for implement Strategy pattern
    /// </summary>
    public abstract class Generation
    {
        internal string WorkingDirectory { get; set; } = "Files with random bytes";

        internal abstract string FileExtension { get; set; }

        internal abstract byte[] GenerateFileContent(int contentLength);

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        internal void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }

    }
}
