using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerService
    {
        [Test]
        public void CheckResult()
        {
            No1.Solution.IChecker checker = new No1.Solution.Checker();
            No1.Solution.ISqlRepository sqlRepository = new No1.Solution.SqlRepository();
            No1.Solution.PasswordCheckerService passwordCheckerService = new No1.Solution.PasswordCheckerService(sqlRepository, checker);

            passwordCheckerService.CheckPassword("dfsaGJifhiefh1231244");

            bool resilt = passwordCheckerService.ToRepository(0);

            Assert.AreEqual(true, resilt);
        }
    }
}
