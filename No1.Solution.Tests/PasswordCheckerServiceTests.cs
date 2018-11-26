using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [TestCase("ilya", ExpectedResult = false)]
        [TestCase("ilya1234", ExpectedResult = true)]
        public bool VerifyPassword_StandardVerifyer_VerifyesPassword(string password)
        {
            IPasswordVerifyer pv = new StandardPasswordVerifyer();
            IRepository repository = new SqlRepository();
            PasswordCheckerService service = new PasswordCheckerService(repository);

            return service.VerifyPassword(password, pv).Item1;
        }

        [TestCase("ilya", ExpectedResult = false)]
        [TestCase("ilya1234", ExpectedResult = false)]
        [TestCase("Ilya1234", ExpectedResult = true)]
        public bool VerifyPassword_AdditionalVerifyer_VerifyesPassword(string password)
        {
            IPasswordVerifyer pv = new AdditionalPasswordVerifyer();
            IRepository repository = new SqlRepository();
            PasswordCheckerService service = new PasswordCheckerService(repository);

            return service.VerifyPassword(password, pv).Item1;
        }
    }
}
