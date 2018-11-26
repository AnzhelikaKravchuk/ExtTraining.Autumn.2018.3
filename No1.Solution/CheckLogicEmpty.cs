using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicEmpty : IChecker
    {
        public bool Check(string password) => password != string.Empty;
    }
}
