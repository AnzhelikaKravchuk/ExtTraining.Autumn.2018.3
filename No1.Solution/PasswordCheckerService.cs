using System;
using System.Linq;

namespace No1.Solution
{
    //Для расширения функционала можно наследоваться от данного класса и переопределять виртуальный метод.
    //Также можно написать метод расширения.
    public class PasswordCheckerService
    {
        public PasswordCheckerService(IRepository repository)
        {
            _repository = repository;
        }
        
        private readonly IRepository _repository;

        public virtual (bool, string) VerifyPassword(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                return (false, $"{password} is empty ");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                return (false, $"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                return (false, $"{password} length too long");

            // check if password contains at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                return (false, $"{password} hasn't alphanumerical chars");

            // check if password contains at least one digit character 
            if (!password.Any(char.IsNumber))
                return (false, $"{password} hasn't digits");

            SaveToRepository(password);

            return (true, "Password is Ok. User was created");
        }

        public virtual void SaveToRepository(string password)
        {
            _repository.Create(password);
        }
    }
}
