using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class Logger : ILogger
    {
        public bool IsWarnEnabled { get; set; } = false;

        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Warn(string message)
        {
            IsWarnEnabled = true;
            Console.WriteLine(message);
        }
    }
}
