using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /// <summary>
    /// Interface for different repositories.
    /// </summary>
    public interface IRepository
    {
        void Create(string password);
    }
}
