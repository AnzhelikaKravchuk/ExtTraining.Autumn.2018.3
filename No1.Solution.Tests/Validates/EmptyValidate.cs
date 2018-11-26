using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    class EmptyValidate : IPasswordValidator
    {
        public void Validate(string password)
        {
            if (password == string.Empty)
            {
                throw new ArgumentException($"{nameof(password)} is empty ");
            }
        }
    }
}
