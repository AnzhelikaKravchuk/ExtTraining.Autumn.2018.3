using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    /// <summary>
    /// Implements IAverage for calculating Mean
    /// </summary>
    public class AverageMean : IAverage
    {
        public double Calculate(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
