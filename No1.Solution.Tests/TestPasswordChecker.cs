using System;
using NUnit.Framework;
using Moq;
using NUnit.Framework.Internal;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class TestPasswordChecker
    {
        private readonly string password = "NET115c#34";

        [Test]
        public void CheckService_True()
        {
            PasswordCheckerService service = new PasswordCheckerService();
            Tuple<bool, string> expected = Tuple.Create(true, $"{nameof(password)} is OK. User was created.");

            Tuple<bool, string> actual = service.VerifyPassword(password, s => s.Length <= 5);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void CheckService_False()
        {
            PasswordCheckerService service = new PasswordCheckerService();
            Tuple<bool, string> expected = Tuple.Create(false, $"{nameof(password)} is wrong");

            Tuple<bool, string> actual = service.VerifyPassword(password, s => s.Contains("NET"));

            Assert.AreEqual(actual, expected);
        }
    }
}
