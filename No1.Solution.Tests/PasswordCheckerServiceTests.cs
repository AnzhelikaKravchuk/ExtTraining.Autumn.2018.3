using System;
using NUnit.Framework;
using Moq;
using No1.Solution.Services.Interfaces;
using No1.Solution.Interfaces;
using No1.Solution.Validators;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        private Mock<IPasswordChekerService<string>> _mock;
        
        [Test]
        public void VerifyPassword_CorrectPassword_CorrectResult()
        {
            string password = "1234fghk";

            var repo = new MockRepository(MockBehavior.Default);
            var reopositoryMock = repo.Create<IPasswordCheckerRepository>();
            reopositoryMock.Setup(lw => lw.Create(password));

            var validationMock = repo.Create<IValidator<string>>();
            validationMock.Setup(lm => lm.IsValid(password)).Returns(Tuple.Create(true, ""));

            var service = new PasswordCheckerService(reopositoryMock.Object, validationMock.Object);

            service.VerifyPassword(password);

            repo.Verify();
        }

        [Test]
        public void VerifyPassword_CorrectPasswordWithValidatorFunction_CorrectResult()
        {
            string password = "1234fghk";

            var repo = new MockRepository(MockBehavior.Default);
            var reopositoryMock = repo.Create<IPasswordCheckerRepository>();
            reopositoryMock.Setup(lw => lw.Create(password));

            var validator = new DefaultPasswordValidator();

            var validationMock = repo.Create<IValidator<string>>();
            validationMock.Setup(lm => lm.IsValid(password)).Returns(validator.IsValid(password));

            var service = new PasswordCheckerService(reopositoryMock.Object, validationMock.Object);

            service.VerifyPassword(password);

            repo.Verify();
        }

        [Test]
        public void VerifyPassword_EmptyPasswordWithValidatorFunction_CorrectResult()
        {
            string password = "";

            var repo = new MockRepository(MockBehavior.Default);
            var reopositoryMock = repo.Create<IPasswordCheckerRepository>();
            reopositoryMock.Setup(lw => lw.Create(password));

            var validator = new DefaultPasswordValidator();

            var validationMock = repo.Create<IValidator<string>>();
            validationMock.Setup(lm => lm.IsValid(password)).Returns(validator.IsValid(password));

            var service = new PasswordCheckerService(reopositoryMock.Object, validationMock.Object);

            service.VerifyPassword(password);

            repo.Verify();
        }
    }
}
