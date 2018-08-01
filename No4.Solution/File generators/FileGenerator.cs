using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public abstract class FileGenerator
    {
        public void GenerateFiles(int filesCount, int contentLength)
        {
            if (filesCount < 1)
            {
                throw new ArgumentException($"{nameof(filesCount)} can't be less than 1!");
            }

            if (contentLength < 1)
            {
                throw new ArgumentException($"{nameof(contentLength)} can't be less than 1!");
            }

            InnerFileGeneration(filesCount, contentLength);
        }

        #region Abstract members
        protected abstract string WorkingDirectory { get; }
        protected abstract string FileExtension { get; }

        protected abstract void InnerFileGeneration(int filesCount, int contentLength);
        #endregion
    }
}
