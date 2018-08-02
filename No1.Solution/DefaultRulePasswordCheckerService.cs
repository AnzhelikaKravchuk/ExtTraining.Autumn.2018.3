using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public sealed class DefaultRulePasswordCheckerService : IPasswordCheckerService
    {
        private readonly IPasswordValidator validator;

        private readonly IRepository repository;

        public DefaultRulePasswordCheckerService(IPasswordValidator validator, IRepository repository)
        {
            this.validator = validator ?? throw new ArgumentNullException($"{nameof(validator)} is null");
            this.repository = repository ?? throw new ArgumentNullException($"{nameof(repository)}");
        }

        public Tuple<string, bool> Verify(string password)
        {
            try
            {
                validator.Validate(password);
                repository.Create(password);
            }
            catch (ArgumentException e)
            {
                return new Tuple<string, bool>(e.Message, false);
            }

            return new Tuple<string, bool>("Password is Ok. User was created", true);
        }
    }
}
