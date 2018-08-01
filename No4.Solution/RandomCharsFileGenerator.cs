using System;
using System.Linq;
using System.Text;

namespace No4.Solution
{
    public class RandomCharsFileGenerator : BaseFileGenerator
    {
        private readonly string _input;

        public RandomCharsFileGenerator(
            string workingDirectory,
            string fileExtension,
            string input)
            : base(workingDirectory, fileExtension)
        {
            _input = input;
        }

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = this.RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int Size)
        {
            var random = new Random();

            var chars = Enumerable.Range(0, Size).Select(x => _input[random.Next(0, _input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
