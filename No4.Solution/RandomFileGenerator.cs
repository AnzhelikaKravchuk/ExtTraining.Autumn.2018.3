using System;
using System.Collections.Generic;

namespace No4.Solution
{
    /// <summary>
    /// Describes random file generator abstract class
    /// </summary>
    public abstract class RandomFileGenerator
    {
        public string WorkingDirectory => "Files with random bytes";

        public string FileExtension => ".bytes";

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        /// <summary>
        /// Abstract method which describes how to generate file content
        /// </summary>
        /// <param name="contentLength">File content length</param>
        /// <returns>Generated array of bytes</returns>
        protected abstract byte[] GenerateFileContent(int contentLength);

        /// <summary>
        /// Abstract method which describes how to writes bytes to file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <param name="content">Content</param>
        protected abstract void WriteBytesToFile(string fileName, byte[] content);        
    }
}
