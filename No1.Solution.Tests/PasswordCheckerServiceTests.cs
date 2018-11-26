using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [TestCase("AAAAAAA22311")]
        [TestCase("123faA21")]
        [TestCase("132150915@A")]
        [TestCase("11Adaafa1233")]
        public void PasswordCheckerService_TakeRightPasswords_ReturnsBools(string password)
        {
            PasswordCheckerService checker = new PasswordCheckerService();
            var actual = checker.VerifyPassword(password);
            Assert.AreEqual(true, actual.Item1);
        }

        [TestCase("AAA")]
        [TestCase("123faA21aaaaaaaaaaaaa")]
        [TestCase("13215091125")]
        [TestCase("AAAbAAAAAAA")]
        public void PasswordCheckerService_TakeWrongPasswords_ReturnsBools(string password)
        {
            PasswordCheckerService checker = new PasswordCheckerService();
            var actual = checker.VerifyPassword(password);
            Assert.AreEqual(false, actual.Item1);
        }

        [TestCase("AAAAAAA22")]
        [TestCase("123faA21aa")]
        public void PasswordCheckerServiceAndAddAdditionalRule_TakeRightPasswords_ReturnsBools(string password)
        {
            PasswordCheckerService checker = new PasswordCheckerService();
            checker.AddAdditionalRule(@"(?=^.{9,10}$)");
            var actual = checker.VerifyPassword(password);
            Assert.AreEqual(false, actual.Item1);
        }

        [TestCase("AAAAAAA22311")]
        [TestCase("123faA21")]
        public void PasswordCheckerServiceAndAddAdditionalRule_TakeWrongPasswords_ReturnsBools(string password)
        {
            PasswordCheckerService checker = new PasswordCheckerService();
            checker.AddAdditionalRule(@"(?=^.{9,10}$)");
            var actual = checker.VerifyPassword(password);
            Assert.AreEqual(false, actual.Item1);
        }
    }
}
