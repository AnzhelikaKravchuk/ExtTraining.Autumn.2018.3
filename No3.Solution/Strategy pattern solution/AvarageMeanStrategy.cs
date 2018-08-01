using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class AvarageMeanStrategy: IAvarageCalculator
    {
        public double GetAvarage(List<double> values)
            => values.Sum() / values.Count;
    }
}