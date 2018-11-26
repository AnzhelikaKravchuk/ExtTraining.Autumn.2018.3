using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public struct CheckerResult
    {
        public bool BoolResult { get; set; }
        public string StringResult { get; set; }
        public string Password { get; set; }

        public CheckerResult(bool result, string message, string password)
        {
            this.BoolResult = result;
            this.StringResult = message;
            this.Password = password;
        }               
    }
}
