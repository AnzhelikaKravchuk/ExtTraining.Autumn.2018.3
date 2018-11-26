using No1.Solution.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Entities
{
    public class SqlRepository : Repository
    {
        public SqlRepository(RepositoryType type) : base(type) { }

        public override bool Create(string password)
        {
            // some realization
            return true;
        }
    }
}
