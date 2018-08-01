using No4.Solution.Content_generators.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Content_generators
{
    public class CharContentGenerator : IContentGenerator
    {
        public byte[] GenerateFileContent(int contentLength)
        {
            string generatedString = RandomStringGenerator.Generate(contentLength);

            return Encoding.Unicode.GetBytes(generatedString);
        }
    }
}
