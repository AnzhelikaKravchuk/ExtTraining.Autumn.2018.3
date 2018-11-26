using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class BytesGenerate : Generation
    {
        internal override string FileExtension { get; set; } = ".bytes";

        /*public BytesGenerate(string workingDirectory) : base(workingDirectory)
        { }*/

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
       
}
