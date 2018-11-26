using NUnit.Framework;
using Moq;
using No1.Solution.Checkers;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void VerifyPassword_SomeRepository_PasswordCreated()
        {
            string testPassword = "1";
            var checkerMock = new Mock<IChecker>();
            checkerMock.Setup(m => m.Check(testPassword)).Returns((true, ""));
            var repMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repMock.Object, new IChecker[] { checkerMock.Object });

            bool isRight;
            string message;
            (isRight, message) = passwordChecker.VerifyPassword(testPassword);

            Assert.IsTrue(isRight);
            repMock.Verify(m => m.Create(testPassword));
        }

        [Test]
        public void VerifyPassword_OldCheckers_PasswordIsRight()
        {
            string testPassword = "asdfg56732";
            IChecker[] checkers = { new EmptyChecker(), new AdminLengthChecker(), new CharacterChecker(), new DigitChecker(), new LengthChecker() };
            var repMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repMock.Object, checkers);

            bool isRight;
            string message;
            (isRight, message) = passwordChecker.VerifyPassword(testPassword);

            Assert.IsTrue(isRight);
        }

        [Test]
        public void VerifyPassword_OldCheckers_PasswordIsWrong()
        {
            string testPassword = "a4";
            IChecker[] checkers = { new EmptyChecker(), new AdminLengthChecker(), new CharacterChecker(), new DigitChecker(), new LengthChecker() };
            var repMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repMock.Object, checkers);

            bool isRight;
            string message;
            (isRight, message) = passwordChecker.VerifyPassword(testPassword);

            Assert.IsFalse(isRight);
        }

        [Test]
        public void VerifyPassword_SomeChecker_PasswordIsRight()
        {
            string testPassword = "1";
            var checkerMock = new Mock<IChecker>();
            checkerMock.Setup(m => m.Check(testPassword)).Returns((true, ""));
            var repMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repMock.Object, new IChecker[] { checkerMock.Object });

            bool isRight;
            string message;
            (isRight, message) = passwordChecker.VerifyPassword(testPassword);

            Assert.IsTrue(isRight);
            checkerMock.Verify(m => m.Check(testPassword));
        }

        [Test]
        public void VerifyPassword_SomeChecker_PasswordIsWrong()
        {
            string testPassword = "1";
            var checkerMock = new Mock<IChecker>();
            checkerMock.Setup(m => m.Check(testPassword)).Returns((false, ""));
            var repMock = new Mock<IRepository>();
            var passwordChecker = new PasswordCheckerService(repMock.Object, new IChecker[] { checkerMock.Object });

            bool isRight;
            string message;
            (isRight, message) = passwordChecker.VerifyPassword(testPassword);

            Assert.IsFalse(isRight);
            checkerMock.Verify(m => m.Check(testPassword));
        }
    }
}
