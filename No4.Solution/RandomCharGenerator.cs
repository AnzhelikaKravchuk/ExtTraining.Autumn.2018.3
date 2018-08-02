using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomCharGenerator : Generator
    {
        private const string Input = "abcdefghijklmnopqrstuvwxyz0123456789";

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var generatedString = RandomString(contentLength);

            var bytes = Encoding.Unicode.GetBytes(generatedString);

            return bytes;
        }

        private string RandomString(int size)
        {
            var random = new Random();

            var chars = Enumerable.Range(0, size).Select(x => Input[random.Next(0, Input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
