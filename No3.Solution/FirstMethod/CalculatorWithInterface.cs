using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class CalculatorWithInterface
    {
        public double CalculateAverage(ICollection<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }
            
            if (averagingMethod == null)
            {
                throw  new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.FindAverage(values);
        }
    }
}
