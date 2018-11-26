using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckerAdapter : IChecker
    {
        private List<IChecker> checkers;

        public CheckerAdapter(IChecker[] checkers)
        {
            if (checkers == null)
            {
                throw new ArgumentNullException($"{nameof(checkers)} need to be not null.");
            }
            this.checkers = new List<IChecker>();
            this.checkers.AddRange(checkers);
        }

        public bool Check(string password)
        {
            return checkers.All(ch => ch.Check(password));
        }
    }
}
