using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class CalculateMean : ICalculate
    {
        public double CalculateAverage(List<double> values) => values.Sum() / values.Count;
    }
}
