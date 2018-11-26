using System;
using System.Linq;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerService
    {
        [TestCase("", false, " is empty " ,ExpectedResult = true)]
        [TestCase("text41", false, "text41 length too short", ExpectedResult = true)]
        [TestCase("gfdre24afewsfgrertdgdrtefdg", false, "gfdre24afewsfgrertdgdrtefdg length too long", ExpectedResult = true)]
        [TestCase("tdsgewsaf", false, "tdsgewsaf hasn't digits", ExpectedResult = true)]
        [TestCase("1412523562", false, "1412523562 hasn't alphanumerical chars", ExpectedResult = true)]

        [Test]
        public bool VerifyPassword_StringPassword_TrueOrFalseAndMessage(string password, bool result, string message)
        {
            IPasswordValidator validator = new SimpleValidator();

            (bool, string) actual = validator.Validate(password);

            return AreEqual(new ValueTuple<bool, string>(result, message), actual);
        }

        public bool AreEqual((bool, string) first, (bool, string) second)
        {
            if (first.Item1 != second.Item1)
            {
                return false;
            }
            if (first.Item2 != second.Item2)
            {
                return false;
            }

            return true;
        }
    }
}
