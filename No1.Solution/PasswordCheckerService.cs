using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly SqlRepository repository;

        private readonly IChecker checker;

        /// <summary>
        /// Constructor checker to validate password
        /// </summary>
        /// <param name="checker"></param>
        public PasswordCheckerService(IChecker checker)
        {
            if (checker == null)
            {
                throw new ArgumentNullException("Checker can't be null!");
            }

            this.checker = checker;
            this.repository = new SqlRepository();
        }

        /// <summary>
        /// Verify password by using checker
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public (bool, string) VerifyPassword(string password)
        {
            repository.Create(password);

            return this.checker.Validate(password);
        }
    }
}
