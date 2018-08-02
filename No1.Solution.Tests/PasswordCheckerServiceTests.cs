using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [TestCase("MAXART", ExpectedResult = "(False, MAXART length too short)")]
        [TestCase("MAXART1405MAXART1405", ExpectedResult = "(False, MAXART1405MAXART1405 length too long)")]
        [TestCase("MAXARRTTT", ExpectedResult = "(False, MAXARRTTT hasn't digits)")]
        [TestCase("MAXART1405", ExpectedResult = "(True, Password is Ok. User was created)")]
        public string VerifyPassword_Result(string password)
        {
            List<IPasswordChecker> checkers = new List<IPasswordChecker>
            {
                new CheckerForNullOrEmpty(),
                new CheckerForMaxLength(),
                new CheckerForMinLength(),
                new CheckerForLetter(),
                new CheckerForDigits()
            };

            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), checkers);

            return service.VerifyPassword(password).ToString();
        }
    }
    public class CheckerForNullOrEmpty : IPasswordChecker
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException($"{password} is null ");
            }
            if(password == String.Empty)
            {
                throw new ArgumentException($"{password} is empty");
            }
            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
    public class CheckerForMinLength : IPasswordChecker
    {
        private const int MinimalLength = 7;

        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password.Length <= MinimalLength)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
    public class CheckerForMaxLength : IPasswordChecker
    {

        private const int MaxLength = 15;

        public Tuple<bool, string> CheckPassword(string password)
        {
            if (password.Length >= MaxLength)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
    public class CheckerForLetter : IPasswordChecker
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
    public class CheckerForDigits : IPasswordChecker
    {
        public Tuple<bool, string> CheckPassword(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
