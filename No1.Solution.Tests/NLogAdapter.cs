using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    class NlogAdapter : ILogger
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public NlogAdapter(Logger log)
        {
            logger = log;
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }
    }
}
