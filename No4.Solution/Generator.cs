using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    abstract public class Generator
    {
        private byte[] _gen;
        public byte[] GenerateBytes(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; i++)
            {
                _gen = GenerateFile(contentLength);
            }

            return _gen;
        }

        protected abstract byte[] GenerateFile(int contentLength);
    }
}
