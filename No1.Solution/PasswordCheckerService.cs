using System;
using System.Linq;
using Moq;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private IRepository repository;
        private Func<string, Tuple<bool, string>> customVerifier;

        
    public PasswordCheckerService(IRepository repository, Func<string, Tuple<bool, string>> customVerifier)
    {
        this.repository = repository;
        this.customVerifier = customVerifier;
    }



        public Tuple<bool, string> VerifyPassword(string password)
        {
            if (customVerifier != null)
            {
                return CustomVerifier(password);
            }
            else
            {
                return DefaultVerifier(password);
            }
        }
        
        private Tuple<bool, string> CustomVerifier(string password)
        {
            foreach (var verifier in customVerifier.GetInvocationList())
            {
                Tuple<bool, string> providedData = verifier.DynamicInvoke(password) as Tuple<bool, string>;
                if (providedData.Item1 == false)
                    return Tuple.Create(false, providedData.Item2);
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");

        }

        private Tuple<bool, string> DefaultVerifier(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
