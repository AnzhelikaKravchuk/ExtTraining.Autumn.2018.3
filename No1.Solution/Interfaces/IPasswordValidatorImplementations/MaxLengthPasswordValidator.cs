using System;

namespace No1.Solution.Interfaces.IPasswordValidatorImplementations
{
    public class MaxLengthPasswordValidator : IPasswordValidator
    {
        private readonly int _maxPasswordLength;
        public MaxLengthPasswordValidator(int maxPasswordLength)
        {
            if (maxPasswordLength <= 0)
            {
                throw new ArgumentException(nameof(maxPasswordLength) + "must be greater than 0.");
            }

            _maxPasswordLength = maxPasswordLength;
        }

        public (bool, string) IsValid(string password)
        {
            if (password.Length > _maxPasswordLength)
                return (false, $"{password} length too long");

            return (true, "Password is Ok. User was created");
        }
    }
}
