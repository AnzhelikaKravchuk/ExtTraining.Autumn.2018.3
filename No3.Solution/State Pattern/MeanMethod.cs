using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.State_Pattern
{
    public class MeanMethod : IAveragingMethod
    {
        public double Calculate(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
