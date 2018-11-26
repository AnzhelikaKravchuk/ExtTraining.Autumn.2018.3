using System;
using System.Linq;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;
        private Func<string, Tuple<bool, string>>[] validators;

        public PasswordCheckerService(IRepository currRepo, params Func<string, Tuple<bool, string>>[] currVals)
        {
            if (currRepo == null || currVals == null)
                throw new ArgumentNullException();

            if (currVals.Length < 1)
                throw new ArgumentException("There must be at least one validator");

            repository = currRepo;
            validators = currVals;
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result;
            foreach (var varifier in validators)
            {
                result = varifier(password);
                if (!(result.Item1))
                    return result;
            }

            repository.Create(password);

            return Tuple.Create(true, "Password is Ok. User was created");
        }
    }
}
