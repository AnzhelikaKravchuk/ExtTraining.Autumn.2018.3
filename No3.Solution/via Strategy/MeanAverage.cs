using System.Linq;

namespace No3.Solution.via_Strategy
{
    public class MeanAverage : IAverage
    {
        public double Calculate(double[] values) => values.Sum() / values.Count();
    }
}
