using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /// <summary>
    /// static class that implements validation function
    /// </summary>
    ///
    /// Ive deside to rewrite the HARDCODE part of privious code.
    /// Also ive desided to make this class static, cos we need to check the password 1 time only.
    /// Delete the ValueTypes cos of version problems in tests.
    /// 
    public static class PasswordCheckerService
    {
        public static bool CheckPassword(IRepositorable repos, string password, params Predicate<string>[] validators)
        {
            foreach (var validate in validators)
            {
                if (!validate(password)) { return false; }

            }
            repos.Create(password);
            return true;
        }
    }
}
