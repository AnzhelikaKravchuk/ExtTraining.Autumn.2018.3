using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class No1Tests
    {
        IRepository rep = null;
        [TestCase(null)]
        [TestCase("123")]
        public void No1_InvalidFormat_ArgumentNullException(string password)
        {
            PasswordCheckerService pcs = new PasswordCheckerService();            
            Assert.Throws<ArgumentNullException>(() => pcs.VerifyPassword(password, rep));
        }
    }
}
