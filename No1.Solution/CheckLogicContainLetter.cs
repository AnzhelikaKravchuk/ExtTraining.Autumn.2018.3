using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicContainLetter : IChecker
    {
        public bool Check(string password) => password.Any(char.IsLetter);
    }
}
