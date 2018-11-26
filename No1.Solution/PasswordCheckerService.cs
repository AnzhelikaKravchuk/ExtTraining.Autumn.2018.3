using System;
using System.Collections.Generic;
using System.Linq;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private readonly IPasswordValidator validator;
        private readonly ILogger logger;

        public PasswordCheckerService(IPasswordValidator validator, IRepository repository)
        {
            this.validator = validator;
        }
       
        public bool AddPassword(string password)
        {
            if (validator.VerifyPassword(password))
            {
                repository.Create(password);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
