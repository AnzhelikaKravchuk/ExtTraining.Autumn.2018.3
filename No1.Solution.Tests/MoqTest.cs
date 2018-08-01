using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class MoqTest
    {
        [Test]
        public void VirifyPassword()
        {
            var mock = new Mock<IPasswordCheckerService<string>>();
            var mockRep = new Mock<IRepository<string>>();
            mock.Setup(a => a.VerifyPassword(It.IsAny<string>()));
            mockRep.Setup(a => a.Create(It.IsAny<string>()));

            var mockService = new Mock<Service<string>>();

            Service<string> service = new Service<string>(mock.Object,mockRep.Object);

            service.VirifyPassword("hellomy8f");

            mockService.Verify(x => x.VirifyPassword(It.IsAny<string>()));

        }
    }
}
