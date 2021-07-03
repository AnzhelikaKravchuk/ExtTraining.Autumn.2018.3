using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class Checking
    {
        public class CheckForLength : IPasswordCheck
        {
            public Tuple<bool, string> CheckPassword(string password)
            {
                // check if length more than 7 chars 
                if (password.Length <= 7)
                    return Tuple.Create(false, "password length too short");

                // check if length more than 10 chars for admins
                if (password.Length >= 15)
                    return Tuple.Create(false, "password length too long");

                return Tuple.Create(true, "Password is validated");
            }
        }

        public class CheckForSymbols : IPasswordCheck
        {
            public Tuple<bool, string> CheckPassword(string password)
            {
                // check if password conatins at least one alphabetical character 
                if (!password.Any(char.IsLetter))
                    return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

                // check if password conatins at least one digit character 
                if (!password.Any(char.IsNumber))
                    return Tuple.Create(false, $"{password} hasn't digits");

                return Tuple.Create(true, "Password is validated");
            }
        }

        public class CheckForNull : IPasswordCheck
        {
            public Tuple<bool, string> CheckPassword(string password)
            {
                if (password == null)
                    throw new ArgumentException("password is null");

                if (password == string.Empty)
                    return Tuple.Create(false, "password is empty");

                return Tuple.Create(true, "Password is validated");
            }
        }
    }
}
