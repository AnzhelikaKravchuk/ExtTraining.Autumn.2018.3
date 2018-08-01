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
        private readonly string _password;
        private readonly Predicate<string> _predicate;
        private readonly string _errorMessagee;

        public PasswordCheckerService(
            IRepository repository,
            string password,
            Predicate<string> predicate,
            string errorMessage)
        {
            ValidateParameters(repository, password, predicate, errorMessage);

            _repository = repository;
            _password = password;
            _predicate = predicate;
            _errorMessagee = errorMessage;
        }

        public Tuple<bool, string> VerifyPassword(string passwordToCheck)
        {
            if (!_predicate.Invoke(passwordToCheck))
            {
                return Tuple.Create(false, $"{_errorMessagee}");
            }

            _repository.Create(passwordToCheck);

            return Tuple.Create(true, "Password is Ok. User was created");
        }

        private void ValidateParameters(
            IRepository repository,
            string password,
            Predicate<string> predicate,
            string errorMessage)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(repository)} can't be null");
            }

            if (password == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(password)} can't be null");
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(predicate)} can't be null");
            }

            if (errorMessage == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(errorMessage)} can't be null");
            }
        }

    }
}
