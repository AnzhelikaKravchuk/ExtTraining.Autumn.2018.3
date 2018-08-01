using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    public class Service<T>
    {
        private readonly IPasswordCheckerService<T> passwordCheckerService;

        private readonly IRepository<T> repository;

        public Service(IPasswordCheckerService<T>  passwordCheckerService,IRepository<T> repository)
        {
            this.passwordCheckerService = passwordCheckerService;
            this.repository = repository;
        }

        public void VirifyPassword(T password)
        {
            if (passwordCheckerService.VerifyPassword(password).Item1)
            {
                repository.Create(password);
            }
        }
    }
}
