using NUnit.Framework;
using System;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            Func<string, Tuple<bool, string>> func = (password) =>
            {
                if (password.Length == 2)
                    return Tuple.Create(false, "Lenth is 2");
                else return Tuple.Create(true, "Everething is ok");
            };

            IRepository repository = new SqlRepository();
            PasswordCheckerService service = new PasswordCheckerService(repository, func);

            Assert.AreEqual(Tuple.Create(false, "Lenth is 2"), service.VerifyPassword("22"));


            service = new PasswordCheckerService(repository, null);
            service.VerifyPassword("Hello");
            Assert.AreEqual(Tuple.Create(true, "Password is Ok. User was created"), service.VerifyPassword("3sd78785"));
        }

        [Test]
        public void MoqMethod()
        {

            var mock = new Mock<IRepository>();

            PasswordCheckerService service = new PasswordCheckerService(mock.Object, null);
            service.VerifyPassword("Hel7878lo");
            mock.Verify(ver => ver.Create(It.IsAny<string>()));
        }
    } 
}

