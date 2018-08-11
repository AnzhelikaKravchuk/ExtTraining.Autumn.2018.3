using NLog;
using NUnit.Framework;
using System;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [TestCase(("123456789a"), ExpectedResult = true)]
        [TestCase(("y4$123456789a"), ExpectedResult = true)]
        [TestCase(("123456789"), ExpectedResult = false)]
        [TestCase(("123456789123456789"), ExpectedResult = false)]
        [TestCase(("12345"), ExpectedResult = false)]
        [TestCase(("aftryeidj"), ExpectedResult = false)]
        [TestCase(("aftryeidjffjldhgjfhgfhgkjffg"), ExpectedResult = false)]
        [TestCase((""), ExpectedResult = false)]
        [TestCase((null), ExpectedResult = false)]
        public bool VerifyPassword(string password)
        {
            return new PasswordCheckerService().VerifyPassword(password);
        }
    }
}
