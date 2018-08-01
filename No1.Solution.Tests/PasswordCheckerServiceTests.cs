using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using No1.Solution.Validation;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        #region NUnit tests
        [TestCase("12345", ExpectedResult = true)]
        [TestCase("sdsdsdsd", ExpectedResult = true)]
        [TestCase("", ExpectedResult = false)]
        public bool VerifyPassword_DefaultValidator_IsCorrect(string password)
        {
            DefaultValidator validator = new DefaultValidator();
            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), validator);

            return service.VerifyPassword(password).Item1;
        }

        [TestCase("12345", ExpectedResult = false)]
        [TestCase("sdsdsdsdssssssssssssssssssssssssssssssssss", ExpectedResult = true)]
        [TestCase("", ExpectedResult = false)]
        public bool VerifyPassword_LengthValidator_IsCorrect(string password)
        {
            LengthValidator validator = new LengthValidator();
            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(), validator);

            return service.VerifyPassword(password).Item1;
        }

        [Test]
        public void VerifyPassword_DefaultValidator_NullPassword_ArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(new SqlRepository(), new DefaultValidator()).VerifyPassword(null));

        [Test]
        public void VerifyPassword_LengthValidator_NullPassword_ArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(new SqlRepository(), new LengthValidator()).VerifyPassword(null));
        #endregion

        #region Moq tests
        //мб когда-нибудь
        #endregion
    }
}
