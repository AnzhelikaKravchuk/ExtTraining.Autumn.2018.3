using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class No1SolutionTest
    {
        [TestCase ("12345678910")]
        public void GithubChecker_ValiData_ValidResult(string password)
        {
            PasswordCheckerService service = new PasswordCheckerService(new GithubChecker());

            Assert.AreEqual(service.VerifyPassword(password), (true, "Password is Ok. User was created"));
        }

        [TestCase ("12345678910")]
        public void SqlChecker_ValiData_ValidResult(string password)
        {
            PasswordCheckerService service = new PasswordCheckerService(new SqlChecker());

            Assert.AreEqual(service.VerifyPassword(password), (true, "Password is Ok. User was created"));
        }

        [TestCase("12345")]
        public void SqlChecker_InValiData_ValidResult(string password)
        {
            PasswordCheckerService service = new PasswordCheckerService(new SqlChecker());

            Assert.AreEqual(service.VerifyPassword(password), (false, $"{password} length too short"));
        }

        [TestCase("qwertyforeveyyyyyyyyyyyyyyyyyyr")]
        public void GithubChecker_InValidData_ValidResult(string password)
        {
            PasswordCheckerService service = new PasswordCheckerService(new SqlChecker());

            Assert.AreEqual(service.VerifyPassword(password), (false, $"{password} length too long"));
        }
    }
}
