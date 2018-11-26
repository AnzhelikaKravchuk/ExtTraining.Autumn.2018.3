using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace No1.Solution.Test
{
    [TestClass]
    public class PasswordCheckServiceTests
    {
        private Func<string, Tuple<bool, string>>[] _conditions;
        private string _filePath;
        private PasswordCheckerService _passwordCheckService;

        [TestInitialize]
        public void Initialization()
        {
            _filePath = "./Passwords.txt";
            _passwordCheckService = new PasswordCheckerService();

            _conditions = new Func<string, Tuple<bool, string>>[6]
            {
                (password) => (new Tuple<bool, string>(password == string.Empty, $"{password} is empty")),
                (password) => (new Tuple<bool, string>(password.Length <= 7, $"{password} length too short")),
                (password) => (new Tuple<bool, string>(password.Length >= 15, $"{password} length too long")),
                (password) => (new Tuple<bool, string>(!password.Any(char.IsLetter), $"{password} hasn't alphanumerical chars")),
                (password) => (new Tuple<bool, string>(!password.Any(char.IsNumber), $"{password} hasn't digits")),
                (password) => (new Tuple<bool, string>(!char.IsUpper(password[0]), $"{password} must starts  with upper letter"))
            };
        }

        [TestMethod]
        public void IncorrectLegnthTest()
        {
            string password = "incorrectLength!";

            var actual = _passwordCheckService.VerifyPassword
                (new TextFileRepository(_filePath), _conditions, password);            
            var expected = new Tuple<bool, string>(false, $"incorrectLength! length too long");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EmplyStringTest()
        {
            string password = string.Empty;

            var actual = _passwordCheckService.VerifyPassword
                (new TextFileRepository(_filePath), _conditions, password);
            var expected = new Tuple<bool, string>(false, $" is empty");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectPasswordTest()
        {
            string password = "CorrectPass1";

            var actual = _passwordCheckService.VerifyPassword
                (new TextFileRepository(_filePath), _conditions, password);
            var expected = new Tuple<bool, string>(true, $"Password is Ok. User was created");

            Assert.AreEqual(expected, actual);
        }
    }
}
