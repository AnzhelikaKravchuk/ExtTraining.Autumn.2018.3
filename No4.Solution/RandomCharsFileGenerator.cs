using System;
using System.IO;
using System.Linq;
using System.Text;

namespace No4.Solution
{
    public class RandomCharsFileGenerator : RandomFileGenerator
    {
        public RandomCharsFileGenerator(string directory)
        {
            this.WorkingDirectory = directory;
            this.FileExtension = ".txt";
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int size)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}