using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution
{
     [TestFixture]
     class NUnitTests
     {
          [Test]
          public void checkPassword()
          {
               PasswordCheckerService passwordCheckerService = new PasswordCheckerService();
               Assert.AreEqual(false, passwordCheckerService.VerifyInputData("vitapetrovs", new PasswordVerification(), new SqlRepository()));
               Assert.AreEqual(false, passwordCheckerService.VerifyInputData("vitapetrovskaya111", new PasswordVerification(), new SqlRepository()));

               Assert.AreEqual(false, passwordCheckerService.VerifyInputData("newtest12", new СomplicatedVerifacation(), new SqlRepository()));
               Assert.AreEqual(true, passwordCheckerService.VerifyInputData("NewTest12", new СomplicatedVerifacation(), new SqlRepository()));
          }
     }
}
