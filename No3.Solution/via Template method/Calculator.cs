using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.via_Template_method
{
    public class Calculator
    {
        private readonly AverageAlgorithm DEFAULT_AVERAGE_METHOD = new MeanMethod();

        public double CalculateAverage(double[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return DEFAULT_AVERAGE_METHOD.Calculate(values);
        }

        public double CalculateAverage(double[] values, AverageAlgorithm averageMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averageMethod == null)
            {
                throw new ArgumentNullException(nameof(averageMethod));
            }

            return averageMethod.Calculate(values);
        }
    }
}
