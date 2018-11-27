using No3.Solution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return new AveragingMethodMean().Calculate(values);
        }

        public double CalculateAverage(IEnumerable<double> values, IMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.Calculate(values);
        }
    }

}
