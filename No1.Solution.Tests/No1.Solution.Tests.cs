using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    // 3 public repositories
    class SqlRepository : IRepositorable
    {
        void IRepositorable.Create(string password) { }
    }

    class TextRepository : IRepositorable
    {
        void IRepositorable.Create(string password) { }
    }

    class XmlRepository : IRepositorable
    {
        void IRepositorable.Create(string password) { }
    }

    [TestFixture()]
    class No1PasswordChecker
    {

        // 3 private predicates
        private bool ConatainsDigits(string s)
        {
            var digits = new []{ '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            foreach (var digit in digits)
            {
                if (s.Contains(digit))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsWiteSpaces(string s)
        {
            return s.Contains(' ');
        }

        private bool IsCapitalized(string s)
        {
            string str = (string)s.Clone();

            return s == str.ToUpper();
        }

        [Test]
        public void ValidPassword_Validator1_ValidPassword()
        {
            var password = "123";
            var repos = new SqlRepository();

            Predicate<string> validator = ConatainsDigits;

            Assert.IsTrue(PasswordCheckerService.CheckPassword(repos, password, validator));
        }

        [Test]
        public void ValidPassword_Validator2_ValidPassword()
        {
            var password = "12 3";
            var repos = new TextRepository();

            Predicate<string> validator = ContainsWiteSpaces;

            Assert.IsTrue(PasswordCheckerService.CheckPassword(repos, password, validator));
        }

        [Test]
        public void ValidPassword_Validator3_ValidPassword()
        {
            var password = "123";
            var repos = new XmlRepository();

            Predicate<string> validator = IsCapitalized;

            Assert.IsTrue(PasswordCheckerService.CheckPassword(repos, password, validator));
        }

        [Test]
        public void ValidPassword_ValidatorParams_ValidPassword()
        {
            var password = "123 PASSWORD";
            var repos = new SqlRepository();

            Predicate<string> validator1 = ConatainsDigits;
            Predicate<string> validator2 = ContainsWiteSpaces;
            Predicate<string> validator3 = IsCapitalized;

            Assert.IsTrue(PasswordCheckerService.CheckPassword(repos, password, validator1, validator2, validator3));
        }

    }
}
