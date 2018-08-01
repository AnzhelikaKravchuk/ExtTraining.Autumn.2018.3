using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class AvarageMean: CalculateAvarage
    {
        public override double GetAvarage(List<double> values)
            => values.Sum() / values.Count;
    }
}
