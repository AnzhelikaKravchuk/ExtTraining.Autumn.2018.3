using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    class NullValidate : IPasswordValidator
    {
        public void Validate(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{nameof(password)} is null arg");
            }
        }
    }
}
