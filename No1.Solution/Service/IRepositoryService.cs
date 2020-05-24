using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Service
{
    public interface IRepositoryService
    {
        void Create(string password);
        void PasswordCheckerService(string password);
    }
}
