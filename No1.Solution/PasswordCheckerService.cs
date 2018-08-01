using No1.Solution.Repositories;
using No1.Solution.Validation;
using System;

namespace No1
{
    public class PasswordCheckerService
    {
        #region Constants
        private readonly IValidator DEFAULT_VALIDATOR = new DefaultValidator();
        #endregion

        #region Private fields
        private IRepository _repository;
        private IValidator _validator;
        #endregion

        #region .ctors
        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} can't be equal to null!");
            _validator = DEFAULT_VALIDATOR;
        }

        public PasswordCheckerService(IRepository repository, IValidator validator)
        {
            _repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} can't be equal to null!");
            _validator = validator ?? throw new ArgumentNullException($"{nameof(validator)} can't be equal to null!");
        }
        #endregion

        #region Public API
        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result = _validator.IsValid(password);

            if (result.Item1)
            {
                _repository.Create(password);
            }

            return result;
        }
        #endregion
    }
}