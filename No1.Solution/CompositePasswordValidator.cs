using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CompositePasswordValidator : IPasswordValidator
    {
        private readonly IEnumerable<IPasswordValidator> validators;

        public CompositePasswordValidator(IEnumerable<IPasswordValidator> validators)
        {
            this.validators = validators;
        }

        public bool VerifyPassword(string password)
        {
            return validators.All(v => v.VerifyPassword(password));
        }
    }
}
