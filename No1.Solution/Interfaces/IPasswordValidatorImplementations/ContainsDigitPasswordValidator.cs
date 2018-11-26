using System.Linq;

namespace No1.Solution.Interfaces.IPasswordValidatorImplementations
{
    public class ContainsDigitPasswordValidator : IPasswordValidator
    {
        public (bool, string) IsValid(string password)
        {
            if (!password.Any(char.IsLetter))
                return (false, $"{password} hasn't alphanumerical chars");

            return (true, "Password is Ok. User was created");
        }
    }
}
