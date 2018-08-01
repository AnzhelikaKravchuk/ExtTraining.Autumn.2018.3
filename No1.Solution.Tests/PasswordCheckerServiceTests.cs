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
        [TestCase("abcderf", ExpectedResult = "(False, abcderf length too short)")]
        [TestCase("abcderff", ExpectedResult = "(False, abcderff hasn't digits)")]
        [TestCase("abcderff4", ExpectedResult = "(True, Password is Ok. User was created)")]
        public string VerifyPassword_Result(string password)
        {
            var verifiers = new IVerifier[]
                                {
                                    new MinLengthPasswordVerifier(), new DigitPasswordVerifier(),
                                    new LetterPasswordVerifier()
                                };

            PasswordCheckerService service =
                new PasswordCheckerService(new SqlRepository(), verifiers);

            return service.VerifyPassword(password).ToString();
        }
    }

    #region Verifiers

    public class NullPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> Verify(string password)
        {
            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class EmptyPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> Verify(string password)
        {
            if (password == string.Empty)
            {
                return Tuple.Create(false, $"{password} is empty ");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class MinLengthPasswordVerifier : IVerifier
    {
        private const int MinimalLength = 7;

        public Tuple<bool, string> Verify(string password)
        {
            if (password.Length <= MinimalLength)
            {
                return Tuple.Create(false, $"{password} length too short");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class MaxLengthPasswordVerifier : IVerifier
    {

        private const int MaxLength = 15;

        public Tuple<bool, string> Verify(string password)
        {
            if (password.Length >= MaxLength)
            {
                return Tuple.Create(false, $"{password} length too long");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class LetterPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> Verify(string password)
        {
            if (!password.Any(char.IsLetter))
            {
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    public class DigitPasswordVerifier : IVerifier
    {
        public Tuple<bool, string> Verify(string password)
        {
            if (!password.Any(char.IsNumber))
            {
                return Tuple.Create(false, $"{password} hasn't digits");
            }

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }

    #endregion
}
