using NLog;
using NUnit.Framework;
using System;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [Test]
        public void VerifyPassword_Vaild()
        {
            string password = "123456789";
            PasswordCheckerService passwordChecker = new PasswordCheckerService();
            //Logger logger = passwordChecker.VerifyPassword(password).Item2;
            Assert.True(passwordChecker.VerifyPassword(password).Item1);
        }
    }
}
