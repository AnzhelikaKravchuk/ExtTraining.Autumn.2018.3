using System;
using System.Linq;

namespace No1.Solution.Validation
{
    public class AlphabeticValidator : IValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == null)
                throw new ArgumentNullException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
