using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class DigitPasswordValidator : IPasswordValidator
    {
        private ILogger logger;

        public DigitPasswordValidator(ILogger logger)
        {
            this.logger = logger;
        }

        public bool VerifyPassword(string password)
        {
            // check if password contains at least one digit character 
            if (!password.Any(char.IsNumber))
            {
                logger.Warn($"{password} hasn't digits");
                return false;
            }
            return true;
        }
    }
}
