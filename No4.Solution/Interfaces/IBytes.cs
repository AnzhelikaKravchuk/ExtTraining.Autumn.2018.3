using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution.Interfaces
{
    /// <summary>
    /// использовал интерфейс для абстракции методов
    /// </summary>
    public interface IBytes
    {
        void GenerateFiles(int filesCount, int contentLength);
        byte[] GenerateFileContent(int contentLength);
        void WriteBytesToFile(string fileName, byte[] content);
    }
}
