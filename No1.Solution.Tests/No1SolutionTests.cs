using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class No1SolutionTests
    {
        [Test]
        public void DifferentConditionalTets()
        {
            string password = "12345678901234567890";
            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository());
            Assert.IsFalse(service.VerifyPassword(password));
        }
    }
}
