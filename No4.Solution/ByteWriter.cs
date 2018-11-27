using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace No4.Solution
{
    public class ByteWriter : IWriter
    {
        public void WriteBytesToFile(string workingDirectory, string fileName, byte[] content)
        {
            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
            }

            File.WriteAllBytes($"{workingDirectory}//{fileName}", content);
        }
    }
}
