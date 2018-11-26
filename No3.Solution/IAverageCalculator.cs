using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAverageCalculator
    {
        double Average(IEnumerable<double> values);
    }
}
