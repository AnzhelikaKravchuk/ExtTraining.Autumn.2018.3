using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Moq;

namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerTest
    {
        [Test]
        public void MainTest()
        {
            PasswordCheckerService checker = new PasswordCheckerService();
            Assert.IsTrue(checker.VerifyPassword("Roman1998", new PasswordDefaultValidator(),
                new SqlRepository()).Item1);
            Console.WriteLine(checker.VerifyPassword("Roman1998", new PasswordDefaultValidator(),
                new SqlRepository()).Item2);
            Assert.IsFalse(checker.VerifyPassword("Roman", new PasswordDefaultValidator(),
                new SqlRepository()).Item1);
            Console.WriteLine(checker.VerifyPassword("Roman", new PasswordDefaultValidator(),
                new DefaultRepository()).Item2);        

        }
    }
}
