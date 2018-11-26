using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public interface IRandomFileGenerator
    {
        string WorkingDirectory { get;}
        string FileExtension { get; }
        void GenerateFiles(int filesCount, int contentLength);
    }
}
