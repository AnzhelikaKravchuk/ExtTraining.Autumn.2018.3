using System;
using System.Linq;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        public PasswordCheckerService()
        {
            repository = new SqlRepository();
        }

        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        public (bool, string) VerifyPassword(string password, IPasswordValidator validator)
        {
            (bool, string) result = validator.Validate(password);

            if (result.Item1 == false)
            {
                return result;
            }

            repository.Create(password);

            return result;
        }
    }
}
