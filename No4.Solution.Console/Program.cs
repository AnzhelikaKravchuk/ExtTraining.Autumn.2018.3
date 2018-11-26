using System.IO;

namespace No4.Solution.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileBytesGenerator = new RandomBytesFileGenerator();
            var fileCharsGenerator = new RandomCharsFileGenerator();

            fileBytesGenerator.GenerateFiles(15, 50);
            fileCharsGenerator.GenerateFiles(15, 50);

            var fileWithBytes = Directory.GetFiles(fileBytesGenerator.WorkingDirectory);
            var fileWithChars = Directory.GetFiles(fileCharsGenerator.WorkingDirectory);
            

            foreach (var bytes in fileWithBytes)
            {
                System.Console.WriteLine(bytes);
            }
            System.Console.WriteLine();
            foreach (var chars in fileWithChars)
            {
                System.Console.WriteLine(chars);
            }
            

        }
    }
}
