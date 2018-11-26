using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Validates
{
    class LongValidate : IPasswordValidator
    {
        public void Validate(string password)
        {
            if (password.Length >= 15)
            {
                throw new ArgumentException($"{nameof(password)} length too long");
            }
        }
    }
}
