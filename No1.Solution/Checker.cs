using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class Checker : IChecker
    {
        public CheckerResult VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return new CheckerResult(false, $"{password} is empty", password);

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return new CheckerResult(false, $"{password} length too short", password);

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return new CheckerResult(false, $"{password} length too long",password);

            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return new CheckerResult(false, $"{password} hasn't alphanumerical chars",password);

            // check if password contains at least one digit character 
            if (!password.Any(char.IsNumber))
                return new CheckerResult(false, $"{password} hasn't digits", password);

            //repository.Create(password);

            return new CheckerResult(true, "Password is Ok. User was created", password);
        }
    }
}
