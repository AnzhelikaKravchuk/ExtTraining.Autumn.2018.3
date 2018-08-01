using NUnit.Framework;
using System;
using System.Text.RegularExpressions;
using Moq;
using No1.Solution;
using System.Collections.Generic;

namespace No1.Solution.Tests
{
    [TestFixture]
        
    public class No1SolutionTests
    {       
        [TestCase("asfgs56456")]
        [TestCase("sdvggh879")]
        public void VerifyPassword_Method_works_properly(
            string password)
        {
            var mock = new Mock<IRepository>();
            mock.Setup(x => x.Create(password));

            var passwordService = new PasswordCheckerService(
                 mock.Object,
                 password,
                 Check,
                 "Oops!");

            var result = passwordService.VerifyPassword(password);

            var forCheck = new Tuple<bool, string>(true,
                "Password is Ok. User was created");

            mock.Verify(x => x.Create(password), Times.Exactly(1));

            Assert.That(result, Is.EqualTo(forCheck));
        }

        private static bool Check(string password)
        {
            string template = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";
            var regex = new Regex(template);

            if (regex.IsMatch(password))
            {
                return true;
            }

            return false;
        }
    }
}
