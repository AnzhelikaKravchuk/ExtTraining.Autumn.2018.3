using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class MeanCalculation : IAlgorithm
    {
        public double Calculate(IList<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
