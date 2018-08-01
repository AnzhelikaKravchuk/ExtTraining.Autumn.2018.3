using System;

namespace No1.Solution.Validation
{
    public class DefaultValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == null)
                throw new ArgumentNullException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
