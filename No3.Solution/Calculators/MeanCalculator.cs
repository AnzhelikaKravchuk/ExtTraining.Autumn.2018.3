using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.Calculators
{
    public class MeanCalculator : IAverageCalculator
    {
        public double Average(IEnumerable<double> values)
        {
            return values.Sum() / values.Count();
        }
    }
}
