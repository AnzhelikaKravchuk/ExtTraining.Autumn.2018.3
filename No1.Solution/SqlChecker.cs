using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /// <summary>
    /// Class implement specofic validation logic for github
    /// </summary>
    public class SqlChecker : IChecker
    {
        public (bool, string) Validate (string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return (false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return (false, $"{password} length too short");

            if (password.Length >= 15)
            {
                return (false, $"{password} length too long");
            }

            else
            {
                return (true, "Password is Ok. User was created");
            }
        }
    }
}
