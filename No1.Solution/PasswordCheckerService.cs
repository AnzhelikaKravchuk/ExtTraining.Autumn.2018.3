using System;
using System.Collections.Generic;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private readonly List<IChecker> checkers;

        public PasswordCheckerService(IRepository repository, IEnumerable<IChecker> checkers)
        {
            if (repository == null || checkers == null)
            {
                throw new ArgumentNullException();
            }
            this.repository = repository;
            this.checkers = new List<IChecker>(checkers);
        }

        public (bool, string) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            foreach (var checker in checkers)
            {
                bool isRight;
                string message;
                (isRight, message) = checker.Check(password);
                if (!isRight)
                {
                    return (isRight, message);
                }
            }

            repository.Create(password);

            return (true, "Password is Ok. User was created");
        }
    }
}
