using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Checkers;
using No1.Solution.Repositories;
using NUnit.Framework;
using static No1.Solution.PasswordCheckerService;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [TestCase("qwertyfdsaf", ExpectedResult = true)]
        [TestCase("something", ExpectedResult = true)]
        [TestCase("qqqqqqwertyfdsafwertyfdsafqq", ExpectedResult = false)]
        public bool VerifyPassword_VerifierSuccessPasswords(string password)
        {
            var service = new PasswordCheckerService(new SqlRepository(), new Checker());
            
            service.AppendCheckMethod(s => s.Length < 15);
            service.AppendCheckMethod(s => s.Length > 7);

            return service.VerifyPassword(password);
        }
    }
}
