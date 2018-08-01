using System.ComponentModel;

namespace No1.Solution
{
    using System;
    
    public class PasswordCheckerService : IPasswordCheckerService
    {
        private readonly IPasswordRepository passwordRepository;
        private readonly IPasswordValidator passwordValidator;

        public PasswordCheckerService() : this(SqlRepository.Instance, CustomPasswordValidator.Instance)
        {
        }
        
        public PasswordCheckerService(IPasswordRepository passwordRepository, IPasswordValidator passwordValidator)
        {
            this.passwordRepository = passwordRepository ?? throw new ArgumentNullException(nameof(passwordRepository));
            this.passwordValidator = passwordValidator ?? throw new ArgumentNullException(nameof(passwordValidator));
        }

        public Tuple<bool, string> VerifyPassword(string password)
        {
            Tuple<bool, string> result;   
            
            try
            {
                this.passwordValidator.Validate(password);
                this.passwordRepository.Create(password);
                result = new Tuple<bool, string>(true, "Password is Ok. User was created");
            }
            catch (ArgumentException e)
            {
                result = new Tuple<bool, string>(false, e.Message);
            }

            return result;
        }
    }
}
