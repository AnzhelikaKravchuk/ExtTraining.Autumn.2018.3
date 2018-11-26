using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Validates
{
    class DigitsValidate : IPasswordValidator
    {
        public void Validate(string password)
        {
            if (!password.Any(char.IsNumber))
                throw new ArgumentException($"{nameof(password)} hasn't digits");
        }
    }
}
