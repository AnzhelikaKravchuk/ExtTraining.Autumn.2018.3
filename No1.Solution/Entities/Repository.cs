using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Entities
{
    public abstract class Repository
    {
        private RepositoryType type { get; set; }

        public Repository() { }

        public Repository(RepositoryType type)
        {
            this.type = type;
        }

        public abstract bool Create(string password);
    }
}
