using System;
using NUnit.Framework;
using Moq;
using No1.Solution;

namespace No1.Solution.Tests
{
	[TestFixture]
	public class PasswordCheckerServiceTests
	{
		[TestCase("", ExpectedResult = false)]
		[TestCase("1a", ExpectedResult = false)]
		[TestCase("123aaaaaaaaaaaaaa", ExpectedResult = false)]
		[TestCase("1234567", ExpectedResult = false)]
		[TestCase("aaaaaaaaa", ExpectedResult = false)]
		[TestCase("12345abcd", ExpectedResult = true)]
		public bool VerifyPassword_DefaultValidator_TrueIfPasswordValidElseFalse(string password)
		{
			var repository = new Mock<IRepository>();
			var service = new PasswordCheckerService(repository.Object, null);

			return service.VerifyPassword(password).Item1;
		}

		[Test]
		public void VerifyPassword_CustomValidator_TrueIfPasswordValidElseFalse()
		{
			var repository = new Mock<IRepository>();
			var service = new PasswordCheckerService(repository.Object, new CustomValidator());

			Assert.That(service.VerifyPassword("123abc").Item1, Is.EqualTo(true));
			Assert.That(service.VerifyPassword("1234567").Item1, Is.EqualTo(false));
		}

		public class CustomValidator : IPasswordValidator
		{
			public (bool, string) Validate(string password)
			{
				if (password == "123abc")
					return (true, "Ok.");

				return (false, "Invalid");
			}
		}
	}
}
