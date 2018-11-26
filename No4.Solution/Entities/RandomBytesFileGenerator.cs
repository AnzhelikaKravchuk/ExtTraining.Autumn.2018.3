using No4.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Entities
{
    /// <summary>
    /// наследую <see cref="RandomAbstr"/> для наследования конструктора и интерфейс для методов данного класса
    /// </summary>
    public class RandomBytesFileGenerator : RandomAbstr, IBytes
    {
        public RandomBytesFileGenerator(string workDirect, string fileExt) : base(workDirect, fileExt)
        {

        }

        public byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);

                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        public void WriteBytesToFile(string fileName, byte[] content)
        {
            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            if (!File.Exists(@"E:\log.txt"))
            {
                File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
                Console.WriteLine("All bytes have been added!");
            }

            
        }
    }
}
