using System.Collections.Generic;

namespace No1.Solution.Interfaces.IPasswordValidatorImplementations
{
    public class CompositionOfPasswordValidators : IPasswordValidator
    {
        private readonly IEnumerable<IPasswordValidator> _validators;

        public CompositionOfPasswordValidators(IEnumerable<IPasswordValidator> validators)
        {
            _validators = validators;
        }

        public (bool, string) IsValid(string password)
        {
            foreach (var validator in _validators)
            {
                var validatorResult = validator.IsValid(password);
                if (!validatorResult.Item1)
                {
                    return validatorResult;
                }
            }
            
            return (true, "Password is Ok. User was created");
        }
    }
}
