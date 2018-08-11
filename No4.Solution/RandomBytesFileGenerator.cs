using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public override string WorkingDirectory { get; set; } = "Files with random bytes";

        public override string FileExtension { get; set; } = ".bytes";

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
