using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Checkers;
using No1.Solution.Repositories;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private IChecker checker;

        public PasswordCheckerService(IRepository repository, IChecker checker)
        {
            this.repository = repository;
            this.checker = checker;
        }

        public PasswordCheckerService(IRepository repository)
        {
            if (repository is null)
            {
                throw new ArgumentNullException($"{nameof(repository)}, argument repository is null.");
            }

            this.repository = repository;
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

            if (checker.Check(password))
            {
                this.repository?.Create(password);
                return true;
            }

            return false;
        }

        public void AppendCheckMethod(Func<string, bool> checkMethod)
        {
            checker.AppendMethod(checkMethod);
        }

        public void RemoveCheckMethod(Func<string, bool> checkMethod)
        {
            checker.RemoveMethod(checkMethod);
        }

        public void ClearCheckMethods(Func<string, bool> checkMethod)
        {
            checker.ClearMethods();
        }
    }
}