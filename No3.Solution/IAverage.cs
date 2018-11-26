using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    /// <summary>
    /// Interface for calculate average
    /// </summary>
    public interface IAverage
    {
        double Calculate(List<double> values);
    }
}
