using System;
using System.Collections.Generic;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository _repository;
        private readonly IEnumerable<IPasswordChecker> _checkers;

        public PasswordCheckerService(IRepository repository, IEnumerable<IPasswordChecker> checkers)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _checkers = checkers ?? throw new ArgumentNullException(nameof(checkers));
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result = null;

            foreach (var item in _checkers)
            {
                result = item.CheckPassword(password);

                if (result.Item1 == false)
                {
                    break;
                }
            }
            _repository.Create(password);
            return result;
        }
    }
}