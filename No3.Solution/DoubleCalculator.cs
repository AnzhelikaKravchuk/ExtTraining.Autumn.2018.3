using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class DoubleCalculator
    {
        public double CalculateAverage(List<double> values, ICalculator calculatingLogic)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calculatingLogic.Calculate(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>, double> calculatingLogic)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calculatingLogic(values);
        }
    }
}
