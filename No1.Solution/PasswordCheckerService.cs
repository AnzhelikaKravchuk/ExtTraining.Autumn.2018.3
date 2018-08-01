using System;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        public Tuple<bool, string> VerifyPassword(string password, IPasswordValidator validator,
            IRepository repository)
        {
            IsNull(password);
            var result = validator.IsRequired(password);

            if (result.Item1)
            {
                repository.Create(password);
            }

            return result;
        }

        private void IsNull(string value)
        {
            if (value == null)
                throw new ArgumentException($"{value} is null arg");
        }
    }
}
