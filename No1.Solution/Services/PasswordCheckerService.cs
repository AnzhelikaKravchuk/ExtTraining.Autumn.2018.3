using No1.Solution.Interfaces;
using No1.Solution.Services.Interfaces;
using No1.Solution.Validators;
using System;

namespace No1
{
    public class PasswordCheckerService : IPasswordChekerService<string>
    {
        private readonly IPasswordCheckerRepository _repository;
        private readonly IValidator<string> _validator;

        public PasswordCheckerService(IPasswordCheckerRepository repository, IValidator<string> validator)
        {
            _repository = repository ?? throw new ArgumentNullException($"The {nameof(repository)} can't be null!");
            _validator = validator ?? throw new ArgumentNullException($"The {nameof(validator)} can't be null!");
        }
        
        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> validationResult = _validator.IsValid(password);

            if (validationResult.Item1)
            {
                _repository.Create(password);
            }

            return validationResult;
        }
    }
}
