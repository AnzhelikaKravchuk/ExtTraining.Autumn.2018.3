using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAvarageCalculateStrategy
    {
        double Calculate(IEnumerable<double> values);
    }
}
