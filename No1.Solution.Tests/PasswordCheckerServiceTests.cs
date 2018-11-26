using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NUnit.Framework;
namespace No1.Solution.Tests
{
    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [Test]
        public void AddPasswordWithDigits()
        {
            PasswordCheckerService service = new PasswordCheckerService(new DigitPasswordValidator(new NlogAdapter(LogManager.GetCurrentClassLogger())),new SqlRepository());
            service.AddPassword("1232415");
        }
    }
}
