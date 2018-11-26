using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public interface IContentGenerator
    {
        byte[] GenerateFileContent(int contentLength);
    }
}
