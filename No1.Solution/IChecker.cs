using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /// <summary>
    /// Interface for checking password
    /// </summary>
    public interface IChecker
    {
        (bool, string) Validate(string password);
    }
}
