using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class AdditionalPasswordVerifyer : StandardPasswordVerifyer, IPasswordVerifyer
    {
        public override Tuple<bool, string> Verify(string password)
        {
            Tuple<bool, string> result = base.Verify(password);

            if (!result.Item1)
            {
                return result;
            }
            else
            {
                // Check if password contains upper case letters.
                if (!password.Any(char.IsUpper))
                {
                    return new Tuple<bool, string>(false,
                        $"{password} must contain at least one upper case letter");
                }

                return new Tuple<bool, string>(true, "Passwor is ok, user was created");
            }
        }
    }
}
