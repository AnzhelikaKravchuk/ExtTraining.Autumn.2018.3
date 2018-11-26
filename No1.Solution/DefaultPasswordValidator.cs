using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace No1.Solution
    {
        public class DefaultPasswordValidator : IPasswordValidator
        {
            public void Validate(string password)
            {
                if (password == null)
                {
                    throw new ArgumentException($"{nameof(password)} is null arg");
                }

                if (password == string.Empty)
                {
                    throw new ArgumentException($"{nameof(password)} is empty ");
                }

                // check if length more than 7 chars 
                if (password.Length <= 7)
                {
                    throw new ArgumentException($"{nameof(password)} length too short");
                }

                // check if length more than 10 chars for admins
                if (password.Length >= 15)
                {
                    throw new ArgumentException($"{nameof(password)} length too long");
                }

                // check if password conatins at least one alphabetical character 
                if (!password.Any(char.IsLetter))
                {
                    throw new ArgumentException($"{nameof(password)} hasn't alphanumerical chars");
                }

                // check if password conatins at least one digit character 
                if (!password.Any(char.IsNumber))
                {
                    throw new ArgumentException($"{nameof(password)} hasn't digits");
                }
            }
        }
    }

}
