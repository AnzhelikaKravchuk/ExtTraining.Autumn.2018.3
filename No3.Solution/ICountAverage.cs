using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public interface ICountAverage
    {
        double ICount(Delegate.FindAverage average, List<double> values);
    }
}
