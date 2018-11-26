using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No1.Solution;

namespace No1.Solution.Tests
{
    public class XmlRepository : IRepository
    {
        public void Create(string password) { }
    }

    public static class CheckerExt
    {
        public static (bool, string) VerifyPasswordCustom(this PasswordCheckerService checkerService, string password)
        {
            if (string.Empty == password)
                return (false, "Empty password");
            
            checkerService.SaveToRepository(password);

            return (true, "Password is Ok. User was created");
        }
    }

    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void PasswordCheckerServiceTestXmlRepository()
        {
            PasswordCheckerService passwordCheckerXml = new PasswordCheckerService(new XmlRepository());
            var actual = passwordCheckerXml.VerifyPassword("123qw");
            Assert.IsTrue(actual == (false, "123qw length too short"));
        }

        [Test]
        public void PasswordCheckerServiceTestSqlRepository()
        {
            PasswordCheckerService passwordCheckerSql = new PasswordCheckerService(new SqlRepository());
            var actual = passwordCheckerSql.VerifyPasswordCustom("123qw");
            Assert.IsTrue(actual == (true, "Password is Ok. User was created"));
        }
    }
}
