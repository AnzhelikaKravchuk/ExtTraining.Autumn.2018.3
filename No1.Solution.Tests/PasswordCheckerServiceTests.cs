using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution.Interfaces.IRepositoryImplementations;
using No1.Solution.Interfaces;
using No1.Solution.Interfaces.IPasswordValidatorImplementations;


namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [TestCase("asdfgh", ExpectedResult = false)]
        [TestCase("asdfgh1234567890", ExpectedResult = false)]
        [TestCase("asd123", ExpectedResult = false)]
        [TestCase("asdfgh123", ExpectedResult = true)]
        public bool VerifyPassword_CurrentValidation_ResultOfValidation(string password)
        {
            var repository = new SqlRepository();
            var v1 = new ContainsDigitPasswordValidator();
            var v2 = new ContainsCharPasswordValidator();
            var v3 = new MaxLengthPasswordValidator(15);
            var v4 = new MinLengthPasswordValidator(8);
            var validators = new IPasswordValidator[]
            {
                new ContainsDigitPasswordValidator(), new ContainsCharPasswordValidator(),
                new MaxLengthPasswordValidator(15), new MinLengthPasswordValidator(8)
            };

            var validator = new CompositionOfPasswordValidators(validators);

            var checker = new PasswordCheckerService(repository, new []{validator});

            return checker.VerifyPassword(password).Item1;
        }
    }

}
