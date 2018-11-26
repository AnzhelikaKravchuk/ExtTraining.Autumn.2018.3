using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No1.Solution.Tests.Validates;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    class Tests
    {
        [Test]      
        public void ArrayToTextArray_ReturnsArrayOfStringsWithWordsOfDigits()
        {
            IPasswordValidator[] validators = new IPasswordValidator[]{ new NullValidate(), new EmptyValidate(), new DigitsValidate(), new LettersValidate(), new LongValidate(),  new ShortValidate()};
            var repository=new SqlRepository();
            PasswordCheckerService service=new PasswordCheckerService(repository);
            foreach (var validator in validators)
            {
                service.AddValidation(validator);
            }
            Assert.Throws<ArgumentException>(() => service.Verify(null));
            Assert.Throws<ArgumentException>(() => service.Verify(string.Empty));
            Assert.Throws<ArgumentException>(() => service.Verify("123abc"));
            Assert.Throws<ArgumentException>(() => service.Verify("123abc78901234567890"));
            Assert.Throws<ArgumentException>(() => service.Verify("1234567890"));
            Assert.Throws<ArgumentException>(() => service.Verify("abcdefghi"));
        }
    }
}
