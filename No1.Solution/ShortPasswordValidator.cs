using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    class ShortPasswordValidator : IPasswordValidator
    {
        private ILogger logger;

        public ShortPasswordValidator(ILogger logger)
        {
            this.logger = logger;
        }
        public bool VerifyPassword(string password)
        {
            // check if length more than 7 chars 
            if (password.Length <= 7)
                logger.Warn($"{password} length too short");
            return false;
        }
    }
}
