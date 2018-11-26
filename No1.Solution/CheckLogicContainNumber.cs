using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicContainNumber : IChecker
    {
        public bool Check(string password) => password.Any(char.IsNumber);
    }
}

