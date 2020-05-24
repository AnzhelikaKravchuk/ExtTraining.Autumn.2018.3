using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Entities
{
    public class FileRepository : Repository
    {
        public FileRepository(RepositoryType type) : base(type) { }

        public override bool Create(string password)
        {
            // some realization
            return true;
        }
    }
}
