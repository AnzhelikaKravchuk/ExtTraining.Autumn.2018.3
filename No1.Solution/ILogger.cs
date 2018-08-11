using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public interface ILogger
    {
        void Warn(string message);
        void Info(string message);
        bool IsWarnEnabled { get; }
    }
}
