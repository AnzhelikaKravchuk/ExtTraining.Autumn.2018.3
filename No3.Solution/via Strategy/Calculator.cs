using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.via_Strategy
{
    public class Calculator
    {
        private readonly IAverage DEFAULT_AVERAGE_METHOD = new MeanAverage();

        public double CalculateAverage(double[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return DEFAULT_AVERAGE_METHOD.Calculate(values);
        }

        public double CalculateAverage(double[] values, IAverage averageMethod)
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
