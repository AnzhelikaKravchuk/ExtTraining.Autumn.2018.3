using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    /// <summary>
    /// Class to generate random files.
    /// </summary>
    public abstract class AbstractGenerator
    {
        public abstract string FileExtension { get; }

        public abstract string WorkingDirectory { get; }

        /// <summary>
        /// Method to create files with random content.
        /// </summary>
        /// <param name="filesCount">
        /// Amount of files to create.
        /// </param>
        /// <param name="contentLength">
        /// Size of file.
        /// </param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="filesCount"/> or <paramref name="contentLength"/> are less than zero.
        /// </exception>
        public void GenerateFiles(int filesCount, int contentLength)
        {
            if (filesCount < 0)
            {
                throw new ArgumentException(nameof(filesCount) + ", amount of files is less than zero.");
            }

            if (contentLength < 0)
            {
                throw new ArgumentException(nameof(contentLength) + ", length of content is less than zero.");
            }

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
