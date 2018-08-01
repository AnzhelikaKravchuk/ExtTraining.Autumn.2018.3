using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class RandomCharGenerator : Generator
    {
        protected override byte[] GenerateFile(int length)
        {
            var genString = RandomString(length);

            var bytes = Encoding.Unicode.GetBytes(genString);

            return bytes;
        }

        private string RandomString(int length)
        {
            var random = new Random();

            const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

            var chars = Enumerable.Range(0, length).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
