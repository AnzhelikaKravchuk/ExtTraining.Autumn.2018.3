using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> func)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return func(values);
        }

        public double CalculateAverage(List<double> values, IAverage averageCalculator)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return averageCalculator.GetAverage(values);
        }
    }
}
