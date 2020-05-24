using No1.Solution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Factory
{
    public interface IRepositoryFactory
    {
        Repository GetRepository(RepositoryType type);
    }
}
