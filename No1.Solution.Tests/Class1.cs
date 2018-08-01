using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Checkers;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Tester()
        {
            List<IPasswordChecker> checkers = new List<IPasswordChecker>
            {
                new CheckForNullOrEmpty(),
                new CheckForLength(),
                new CheckForLetters()
            };

            IRepository rep = new SQLRepository(checkers);

            string password = "MAXART1405";

            var result = rep.Add(password);

            var expected = Tuple.Create(true, "Password is Ok. User was created");

            foreach (var item in result)
            {
                Assert.AreEqual(item, expected);
            }
        }
    }
}
