using System;
using System.Linq;

namespace No1.Solution
{
    public class PasswordCheckerService : IPasswordRules
    {
        private readonly IRepository _repository;
        private readonly IVerifyPassword _verifyPassword;

        public PasswordCheckerService(IRepository repository, IVerifyPassword verifyPassword)
        {
            _repository = repository;
            _verifyPassword = verifyPassword;
        }

        public (bool, string) VerifyPassword(string password)
        {
            var (success, message) = _verifyPassword.Verify(password);
            if (success)
            {
                _repository.Create(password);
            }

            return (success, message);
        }




    }
}
