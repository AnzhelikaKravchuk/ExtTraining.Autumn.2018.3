using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1
{
    public interface IPasswordChecker
    {
        (bool, string) VerifyPassword(string password);
    }
}
