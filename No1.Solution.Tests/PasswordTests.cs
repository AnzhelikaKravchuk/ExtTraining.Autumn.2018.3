using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordTests
    {
        [Test]
        public void PasswordTest()
        {
            List<IPasswordCheck> check = new List<IPasswordCheck>
            {
                new Checking.CheckForLength(),
                new Checking.CheckForSymbols(),
                new Checking.CheckForNull()
            };

            IReppository reppo = new SqlReppository(check);

            string password = "sertyudr12";

            var result = reppo.Add(password);

            var expected = Tuple.Create(true, "Password is validated");

            foreach(var item in result)
            {
                Assert.AreEqual(item, expected);
            }
        }
    }
}
