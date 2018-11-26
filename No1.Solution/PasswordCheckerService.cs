using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository _repository;

        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository;
        }

        public Tuple<bool, string> VerifyPassword(string password, IPasswordVerifyer verifyer)
        {
            Tuple<bool, string> result = verifyer.Verify(password);

            if (result.Item1)
            {
                _repository.Create(password);
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
