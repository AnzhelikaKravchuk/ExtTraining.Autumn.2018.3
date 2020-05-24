using No1.Solution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Factory
{
    class RepositoryFactory : IRepositoryFactory
    {
        public Repository GetRepository(RepositoryType type)
        {
            if (type == RepositoryType.File)
            {
                return new FileRepository(type);
            }
            else if (type == RepositoryType.SQL)
            {
                return new SqlRepository(type);
            }
            else
            {
                return new SqlRepository(type);
            }
        }
    }
}
