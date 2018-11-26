using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class MeanAlgorithm : IAverageAlgorithm
    {
        public double Calculate(IList<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
