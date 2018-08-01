using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository _repository = new SqlRepository();

        public PasswordCheckerService()
        {
        }

        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository;
        }

        public Tuple<bool, string> VerifyPassword(string password, Func<string, bool> condition)
        {
            if (password == null)
            {
                throw new ArgumentNullException($"{password} is null arg");
            }

            if (condition == null)
            {
                throw new ArgumentNullException($"{condition} is null arg");
            }

            return condition.Invoke(password) ? Tuple.Create(false, $"{nameof(password)} is wrong") : Tuple.Create(true, $"{nameof(password)} is OK. User was created.");
        }
    }
}
