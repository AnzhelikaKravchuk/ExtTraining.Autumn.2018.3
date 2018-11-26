using System;
using System.Linq;
using System.Text;
using No4.Solution;

namespace No4
{
    public class RandomCharsFileGenerator : AbstractFileGenerator
    {
        public RandomCharsFileGenerator()
        {
            WorkingDirectory = "Files with random chars";
            FileExtension = ".bytes";
        }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = RandomString(contentLength);

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