using System.Linq;

namespace No3.Solution.via_Template_method
{
    public class MeanMethod : AverageAlgorithm
    {
        public override double Calculate(double[] values) => values.Sum() / values.Count();
    }
}
