using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public override string WorkingDirectory
        {
            get => "Files with random bytes";
            set { WorkingDirectory = value; }
        }

        public override string FileExtension
        {
            get => ".bytes";
            set { FileExtension = value; }
        }

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
