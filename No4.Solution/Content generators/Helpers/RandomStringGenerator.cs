using System;
using System.Linq;

namespace No4.Solution.Content_generators.Helpers
{
    public static class RandomStringGenerator
    {
        private const string input = "abcdefghijklmnopqrstuvwxyz0123456789";

        public static string Generate(int size)
        {
            Random random = new Random();
            var chars = Enumerable.Range(0, size).Select(x => input[random.Next(0, input.Length)]);

            return new string(chars.ToArray());
        }
    }
}
