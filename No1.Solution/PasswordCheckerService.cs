using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public sealed class PasswordCheckerService //: IPasswordCheckerService
    {
        private Action<string> validator = delegate { };

        private readonly IRepository repository;

        public PasswordCheckerService(IPasswordValidator validator, IRepository repository)
        {
            AddValidation(validator);
            this.repository = repository ?? throw new ArgumentNullException($"{nameof(repository)}");
        }

        public void AddValidation(IPasswordValidator validator)
        {
            if (validator == null)
            {
                throw new ArgumentNullException($"{nameof(validator)} is null");
            }

            this.validator += validator.Validate;
        }

        public (string, bool) Verify(string password)
        {
            validator(password);
            repository.Create(password);
            return ("User was created", true);
        }

    }
}
