using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class Saver
    {
        private readonly string fileExtension = ".txt";

        public void Save(string workingDirectory, byte[] content)
        {
            var generatedFileName = $"{Guid.NewGuid()}{fileExtension}";

            if (!Directory.Exists(workingDirectory))
            {
                Directory.CreateDirectory(workingDirectory);
            }

            File.WriteAllBytes(workingDirectory + "//" + generatedFileName, content);
        }
    }
}
