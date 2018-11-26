using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.CalculateMethods
{
    public interface ICalculater<T>
    {
        T Calculate(IEnumerable<T> values);
    }
}
