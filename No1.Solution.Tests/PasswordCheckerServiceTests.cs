using System.Linq;
using No1.Solution.Repository;
using No1.Solution.Validation;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        private ValidatorComposite<string> _validator;
        private IRepository<string> _repository;

        [OneTimeSetUp]
        public void SetUp()
        {
            _validator = new ValidatorComposite<string>();
            _validator.AddValidator(password => !password.Contains('@') && !password.Contains('#')); 
            _repository = new SqlRepository("test.txt");
        }

        [Test]
        public void VerifyPassword_InvalidPassword_ExpectedFalsePassword()
        {
            var password = "fwfrewq3@";

            var actual = PasswordCheckerService.VerifyPassword(password, _validator, _repository);
            var expected = (false, password);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void VerifyPassword_ValidPassword_ExpectedTruePassword()
        {
            var password = "fwfrewq3bhehih4t";

            var actual = PasswordCheckerService.VerifyPassword(password, _validator, _repository);
            var expected = (true, password);

            Assert.AreEqual(expected, actual);
        }
    }
}