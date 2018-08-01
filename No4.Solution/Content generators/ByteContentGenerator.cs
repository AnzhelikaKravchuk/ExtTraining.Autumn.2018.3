using System;

namespace No4.Solution.Content_generators
{
    public class ByteContentGenerator : IContentGenerator
    {
        public byte[] GenerateFileContent(int contentLength)
        {
            Random random = new Random();
            byte[] result = new byte[contentLength];
            random.NextBytes(result);

            return result;
        }
    }
}
