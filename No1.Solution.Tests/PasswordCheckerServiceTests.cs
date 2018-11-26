using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [TestCase]
        public static void Constructor_NullIrepository_NullArgumentExceptionExpected()
        {
            IRepository repository = null;

            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(repository));
        }

        [TestCase]
        public static void Constructor_SomeRepository_ServiceNotNullExpected()
        {
            IRepository repository = new SomeRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            Assert.NotNull(service);
        }

        [TestCase]
        public static void VerifyPassword_NullString_ServiceNotNullExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = null;

            Assert.Throws<ArgumentException>(() => service.VerifyPassword(password));
        }

        [TestCase]
        public static void VerifyPassword_EmptyString_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = string.Empty;

            var result = service.VerifyPassword(password);

            Assert.AreEqual(false, result.Item1);
        }

        [TestCase]
        public static void VerifyPassword_StringLenghtLessThan7Chars_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = "abc";

            var result = service.VerifyPassword(password);

            Assert.AreEqual(false, result.Item1);
        }

        [TestCase]
        public static void VerifyPassword_StringLenghtMoreThan15Chars_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = "qwertyqwertyqwerty";

            var result = service.VerifyPassword(password);

            Assert.AreEqual(false, result.Item1);
        }

        [TestCase]
        public static void VerifyPassword_StringNotContainsAlphabChars_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = "1234567891";

            var result = service.VerifyPassword(password);

            Assert.AreEqual(false, result.Item1);
        }

        [TestCase]
        public static void VerifyPassword_StringNotContainsDigitChars_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = "qwertyqwert";

            var result = service.VerifyPassword(password);

            Assert.AreEqual(false, result.Item1);
        }

        [TestCase]
        public static void VerifyPassword_ValidString_FalseExpected()
        {
            IRepository repository = new SqlRepository();

            PasswordCheckerService service = new PasswordCheckerService(repository);

            string password = "qwertyq123";

            var result = service.VerifyPassword(password);

            Assert.AreEqual(true, result.Item1);
        }
    }
}
