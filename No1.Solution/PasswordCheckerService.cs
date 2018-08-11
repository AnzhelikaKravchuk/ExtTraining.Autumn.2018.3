using System;
using System.Linq;
using NLog;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private ILogger logger;

        public PasswordCheckerService()
        {
            repository = new SqlRepository();
            logger = new Logger();
        }

        public bool VerifyPassword(string password)
        {
            if (password == null)
            {
                logger.Warn($"{password} is null arg");
                return false;
            }

            if (password == string.Empty)
                logger.Warn($"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                logger.Warn($"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                logger.Warn($"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                logger.Warn($"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                logger.Warn($"{password} hasn't digits");

            if (logger.IsWarnEnabled)
            {
                return false;
            }

            repository.Create(password);
            logger.Info("Password is Ok. User was created");
            return true;
        }

    }
}
