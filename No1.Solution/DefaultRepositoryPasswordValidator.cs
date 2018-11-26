using System;
using System.Linq;

namespace No1.Solution
{
    public class DefaultRepositoryPasswordValidator : IPasswordValidator
    {
        private ILogger logger;

        public DefaultRepositoryPasswordValidator(ILogger logger)
        {
            this.logger = logger;
        }
        public bool VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
            {
                logger.Info($"{password} is empty ");
                return false;
            }
            // check if length more than 10 chars for admins
            if (password.Length >= 15)
            {
                logger.Warn($"{password} length too long");
                return false;
            }

            logger.Info("Password is Ok. User was created");
            return true;
        }
    }
}
