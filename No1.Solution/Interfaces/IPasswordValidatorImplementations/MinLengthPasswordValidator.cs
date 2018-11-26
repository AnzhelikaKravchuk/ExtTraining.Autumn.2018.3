using System;

namespace No1.Solution.Interfaces.IPasswordValidatorImplementations
{
    public class MinLengthPasswordValidator : IPasswordValidator
    {
        private readonly int _minPasswordLength;
        public MinLengthPasswordValidator(int minPasswordLength)
        {
            if (minPasswordLength <= 0)
            {
                throw new ArgumentException(nameof(minPasswordLength) + "must be greater than 0.");
            }

            _minPasswordLength = minPasswordLength;
        }

        public (bool, string) IsValid(string password)
        {
            if (password.Length < _minPasswordLength)
                return (false, $"{password} length too short");
            return (true, "Password is Ok. User was created");
        }
    }
}
