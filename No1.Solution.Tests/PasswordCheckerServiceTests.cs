using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static No1.Solution.PasswordCheckerService;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [TestCase("qwertyfdsaf", ExpectedResult = true)]
        [TestCase("something", ExpectedResult = true)]
        [TestCase("qwerty", ExpectedResult = false)]
        public bool VerifyPassword_VerifierSuccessPasswords(string password)
        {
            var service = new PasswordCheckerService();
            service.Verifier += s => s.Length > 7;
            service.Verifier += s => s.Length < 15;

            return service.VerifyPassword(password);
        }
    }
}
