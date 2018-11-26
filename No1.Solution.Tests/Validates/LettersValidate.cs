using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Validates
{
    class LettersValidate : IPasswordValidator
    {
        public void Validate(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                throw new ArgumentException($"{nameof(password)} hasn't alphanumerical chars");
            }
        }
    }
}
