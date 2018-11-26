using System;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        public Tuple<bool, string> VerifyPassword(
            IRepository repository, Func<string, Tuple<bool, string>>[] validationConditions, string password)
        {
            if (repository == null)
            {
                throw new ArgumentException($"{repository} is null arg");
            }

            if (validationConditions == null)
            {
                throw new ArgumentException($"{validationConditions} is null arg");
            }

            if (password == null)
            {
                throw new ArgumentException($"{password} is null arg");
            }      
            
            foreach (var func in validationConditions)
            {
                var validationResult = func(password);
                if (validationResult.Item1)
                {
                    return new Tuple<bool, string>(false, validationResult.Item2);
                }
            }

            repository.Create(password);

            return new Tuple<bool, string>(true, "Password is Ok. User was created");     
        }
    }
}
