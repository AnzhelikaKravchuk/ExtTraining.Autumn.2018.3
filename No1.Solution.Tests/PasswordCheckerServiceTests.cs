using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void PasswordCheckerService_NullChecker_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(new SqlRepository(), (IChecker) null));
        }

        [Test]
        public void PasswordCheckerService_NullRepository_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(null, new CheckLogicEmpty()));
        }

        [Test]
        public void PasswordCheckerService_Success()
        {
            IChecker[] checker =
            {
                new CheckLogicEmpty(), new CheckLogicMinLength(6), new CheckLogicMaxLength(15),
                new CheckLogicContainLetter(), new CheckLogicContainNumber()
            };
            var service = new PasswordCheckerService(new SqlRepository(), new CheckerAdapter(checker));
            var expected = (true, "Password is Ok. User was created");
            var actual = service.VerifyPassword("password1");
            Assert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }

        [TestCase("test password")]
        [TestCase("test")]
        [TestCase("big test password")]
        [TestCase("12345689")]
        public void PasswordCheckerService_False(string password)
        {
            IChecker[] checker =
            {
                new CheckLogicEmpty(), new CheckLogicMinLength(7), new CheckLogicMaxLength(15),
                new CheckLogicContainLetter(), new CheckLogicContainNumber()
            };
            var service = new PasswordCheckerService(new SqlRepository(), new CheckerAdapter(checker));
            var expected = (false, "");
            var actual = service.VerifyPassword(password);
            Assert.AreEqual(expected.Item1, actual.Item1);
        }
    }
}
