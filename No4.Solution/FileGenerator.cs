using System;
using System.IO;

namespace No4.Solution
{
    /// <summary>
    /// Abstarct class for file generators
    /// </summary>
    public abstract class FileGenerator
    {
        /// <summary>
        /// Gets the working directory.
        /// </summary>
        /// <value>
        /// The working directory.
        /// </value>
        public abstract string WorkingDirectory { get; }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public abstract string FileExtension { get; }

        #region Template Method

        /// <summary>
        /// Generates the files with random content, derived classes will implements appropriate behavior
        /// </summary>
        /// <param name="filesCount">The files count.</param>
        /// <param name="contentLength">Length of the content.</param>
        public void GenerateFiles(int filesCount, int contentLength)
        {
            var generatedFileContent = this.GenerateFileContent(contentLength);

            var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

            this.WriteBytesToFile(generatedFileName, generatedFileContent);
        }

        protected abstract byte[] GenerateFileContent(int contentLength);

        #endregion 

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
