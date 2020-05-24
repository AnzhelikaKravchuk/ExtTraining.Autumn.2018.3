using No1.Solution.Entities;
using No1.Solution.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Service
{
    class RepositoryService : IRepositoryService
    {
        private Repository repository;
        private IRepositoryFactory repositoryFactory;
        
        public RepositoryService(IRepositoryFactory factory)
        {
            if (factory is null)
            {
                throw new ArgumentNullException(nameof(factory));
            }

            this.repositoryFactory = factory;
        }

        public void Create(string password)
        {
            PasswordCheckerService(password);

            repository.Create(password);
        }

        public void PasswordCheckerService(string password)
        {
            if (password == string.Empty && password is null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (password.Length <= 7 && password.Length >= 15)
            {
                throw new ArgumentOutOfRangeException(nameof(password));
            }

            if (!password.Any(char.IsNumber))
            {
                throw new ArgumentException(nameof(password));
            }
        }
    }
}
