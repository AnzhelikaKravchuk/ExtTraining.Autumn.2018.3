using System;
using System.Collections.Generic;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        private readonly IEnumerable<IVerifier> verifiers;

        public PasswordCheckerService(IRepository repository, IEnumerable<IVerifier> verifiers)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this.verifiers = verifiers ?? throw new ArgumentNullException(nameof(verifiers));
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result = null;

            foreach (var item in this.verifiers)
            {
                result = item.Verify(password);
                if (result.Item1 == false)
                {
                    break;
                }
            }

            this.repository.Create(password);

            return result;
        }
    }
}