using System.IO;
using System.Reflection;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = PathString("BytesFolder", "Files with random bytes");
            string fileExtension = ".bytes";

            var generator = new RandomBytesFileGenerator(path, fileExtension);
            generator.GenerateFiles(2, 10);

            var path1 = PathString("CharsFolder", "Files with random chars");
            string fileExtension1 = ".txt";

            var generator1 = new RandomCharsFileGenerator(path1, fileExtension1);
            generator1.GenerateFiles(2, 10);
        }

        private static string PathString(string nameFolder, string nameFile)
        {
            var appFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var bytesFolder = Path.Combine(appFolder, nameFolder);
            Directory.CreateDirectory(bytesFolder);
            return Path.Combine(bytesFolder, nameFile);
        }
    }
}
