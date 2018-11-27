using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution.Tests.Helpers
{
    public static class Conditionals
    {
        public static (bool, string) ConditioanalAdded(this string password)
        {        
            // check if length less than 10 chars 
            if (password.Length <= 20)
                return (false, $"{password} length too short");
            return (true, "Password is Ok. User was created");
        }
    }
}
