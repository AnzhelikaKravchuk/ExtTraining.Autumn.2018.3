using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;

        public Func<string, bool> Verifier;

        public PasswordCheckerService()
        {
            repository = new SqlRepository();
        }

        public PasswordCheckerService(IRepository repository)
        {
            if (repository is null)
            {
                throw new ArgumentNullException($"{nameof(repository)}, argument repository is null.");
            }

            Repository = repository;
        }

        private IRepository Repository
        {
            get => repository;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException($"{nameof(value)}. Repository argument is null.");
                }

                repository = value;
            }
        }

        public bool VerifyPassword(string password)
        {
            if (password is null)
            {
                throw new ArgumentNullException($"{nameof(password)} is null argument.");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
               throw new ArgumentException($"{nameof(password)} is empty argument.");
            }

            if (Verifier(password))
            {
                Repository?.Create(password);
                return true;
            }

            return false;
        }
    }
}