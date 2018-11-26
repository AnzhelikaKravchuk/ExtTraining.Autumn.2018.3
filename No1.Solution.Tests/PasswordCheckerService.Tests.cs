using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTest
    {
        [TestCase("", ExpectedResult = false)]
        [TestCase("123", ExpectedResult = false)]
        [TestCase("12345678", ExpectedResult = false)]
        [TestCase("sdfsdfsd", ExpectedResult = false)]
        [TestCase("sdfsdfs1283718273281468214d", ExpectedResult = false)]
        [TestCase("sdf281468214d", ExpectedResult = true)]
        public bool VerifyPassword_OldFunctionality_ExpectedResult(string pass)
        {
            PasswordCheckerService service = new PasswordCheckerService(new SqlRepository(),
                                                            (password) =>
                                                            {
                                                                if (password == null)
                                                                    throw new ArgumentException($"{password} is null arg");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            },
                                                            (password) =>
                                                            {
                                                                if (password == string.Empty)
                                                                    return Tuple.Create(false, $"{password} is empty ");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            },
                                                            (string password) =>
                                                            {
                                                                if (password.Length <= 7)
                                                                    return Tuple.Create(false, $"{password} length too short");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            },
                                                            (string password) =>
                                                            {
                                                                if (password.Length >= 15)
                                                                    return Tuple.Create(false, $"{password} length too long");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            },
                                                            (string password) =>
                                                            {
                                                                if (!password.Any(char.IsLetter))
                                                                    return Tuple.Create(false, $"{password} hasn't alphanumerical chars");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            },
                                                            (string password) =>
                                                            {
                                                                if (!password.Any(char.IsNumber))
                                                                    return Tuple.Create(false, $"{password} hasn't digits");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            });

            var result = service.VerifyPassword(pass);
            return result.Item1;
        }

        class SomeRepository : IRepository
        {
            public void Create(string password) { }
        }

        [TestCase("", ExpectedResult = true)]
        [TestCase("123", ExpectedResult = true)]
        [TestCase("12345678", ExpectedResult = true)]
        [TestCase("FKJSEBFKJE", ExpectedResult = true)]
        [TestCase("sdfsdfs1283718273281468214d", ExpectedResult = false)]
        [TestCase("JHWJHWbhwHBJB", ExpectedResult = false)]
        public bool VerifyPassword_NewFunctionality_ExpectedResult(string pass)
        {      
            PasswordCheckerService service = new PasswordCheckerService(new SomeRepository(),
                                                            (password) =>
                                                            {
                                                                if (password.Any(char.IsLower))
                                                                    return Tuple.Create(false, $"{password} contains lower letters");
                                                                else
                                                                    return Tuple.Create(true, $"pass is OK");
                                                            });

            var result = service.VerifyPassword(pass);
            return result.Item1;
        }
    }
}
