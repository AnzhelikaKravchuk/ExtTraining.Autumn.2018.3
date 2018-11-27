using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Interfaces
{
    public interface IMethod
    {
        double Calculate(IEnumerable<double> values);
    }
}
