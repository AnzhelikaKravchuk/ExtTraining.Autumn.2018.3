using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
    public class Generator: AbstractGenerator
    {
        private IRandom random;

        public Generator(IRandom random)
        {
            this.random = random ?? throw new ArgumentNullException(nameof(random));
        }
    }
}
