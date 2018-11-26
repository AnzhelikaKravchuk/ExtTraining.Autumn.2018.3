using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public static class RandomFileGenerator
    {
        public static void GenerateFiles(int filesCount, int contentLength, string dir, string ext, IContentGenerator generator)
        {
            if (filesCount < 1)
                throw new ArgumentException("File amount can't be less than 1");

            if (dir == null || ext == null || generator == null)
                throw new ArgumentNullException();

            if (ext[0] != '.')
                throw new ArgumentException("Extension must start with a dot");

            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = generator.Generate(contentLength);
                var generatedFileName = $"{Guid.NewGuid()}{ext}";
                WriteBytesToFile(generatedFileName, generatedFileContent, dir);
            }
        }

        private static void WriteBytesToFile(string fileName, byte[] content, string dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllBytes($"{dir}//{fileName}", content);
        }
    }
}
