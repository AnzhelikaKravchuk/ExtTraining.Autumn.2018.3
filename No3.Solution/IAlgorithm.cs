using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAlgorithm
    {
        double Calculate(IList<double> values);
    }
}
