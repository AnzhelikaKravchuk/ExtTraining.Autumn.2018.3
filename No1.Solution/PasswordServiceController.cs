using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordServiceController
    {
        private readonly IVerifier verifier;

        private readonly IRepository repository;

        public PasswordServiceController(IVerifier verifier, IRepository repository)
        {
            this.verifier = verifier ?? throw new ArgumentNullException($"{verifier} is null");
            this.repository = repository ?? throw new ArgumentNullException($"{nameof(repository)} is null");
        }

        public void Authorize(string password)
        {
            var passwordIdentityResult = verifier.Verify(password);


            if (passwordIdentityResult.IsSuccess)
            {
                repository.Write(password);
            }

            this.OnPasswordChecked(passwordIdentityResult.Messages);
        }

        public event EventHandler<PasswordCheckedEventArgs> PasswordChecked;

        public void OnPasswordChecked(IEnumerable<string> messages)
        {
            var args = new PasswordCheckedEventArgs(messages);
            this.PasswordChecked?.Invoke(this, args);
        }
    }
}
