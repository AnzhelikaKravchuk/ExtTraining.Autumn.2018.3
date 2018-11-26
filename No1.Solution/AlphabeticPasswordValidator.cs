using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class AlphabeticPasswordValidator : IPasswordValidator
    {
        private ILogger logger;

        public AlphabeticPasswordValidator(ILogger logger)
        {
            this.logger = logger;
        }

        public bool VerifyPassword(string password)
        {
            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
            {
                logger.Warn($"{password} hasn't alphanumerical chars");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
