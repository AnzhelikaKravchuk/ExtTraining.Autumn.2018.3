using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace No1.Solution.Tests
{
    using NUnit.Framework;
    
    [TestFixture]
    public class No1Tests
    {
        [TestCase("123asdfg", ExpectedResult = true)]
        [TestCase(null, ExpectedResult = false)] // Null.
        [TestCase("", ExpectedResult = false)] // Empty
        [TestCase("123asg", ExpectedResult = false)] // Too short.
        [TestCase("1234567890", ExpectedResult = false)] // No letters.
        [TestCase("asdfghjkl", ExpectedResult = false)] // No numbers.
        [TestCase("123456789asdfghjklzxc", ExpectedResult = false)] // Too long.
        public bool CustomPasswordValidatorTests(string password)
        {
            var validator = CustomPasswordValidator.Instance;
            try
            {
                validator.Validate(password);
                return true;
            }
            catch (ArgumentException e)
            {
                return false;
            }
        }

        [Test]
        public void TestPasswordCheckerServiceConstructor()
        {
            var stub = new FakeRepositoryStub();
            
            var passwordColelction = new List<string> {"123asdfg", "123asdfg1", "asdfgjkl"};
            foreach (var password in passwordColelction)
            {
                stub.Create(password);
            }
            
            var checker = new PasswordCheckerService(stub, CustomPasswordValidator.Instance);
            
            // Get private repository field from PasswordCheckerService using reflection.
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.NonPublic;
            FieldInfo field = checker.GetType().GetField("passwordRepository", bindFlags);
            var actual = ((FakeRepositoryStub) field.GetValue(checker)).Passwords;
            
            CollectionAssert.AreEqual(passwordColelction, actual);
        }
    }
}