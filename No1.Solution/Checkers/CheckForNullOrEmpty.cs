using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Checkers
{
    public class CheckForNullOrEmpty : IPasswordChecker
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password == null)
                throw new ArgumentException("password is null");

            if (password == string.Empty)
                return Tuple.Create(false, "password is empty");

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
