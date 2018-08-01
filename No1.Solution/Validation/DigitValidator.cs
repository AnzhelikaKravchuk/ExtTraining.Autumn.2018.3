using System;
using System.Linq;

namespace No1.Solution.Validation
{
    public class DigitValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == null)
                throw new ArgumentNullException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
