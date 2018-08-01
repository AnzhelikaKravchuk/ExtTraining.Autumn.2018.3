using System;
using System.Collections.Generic;

namespace No3.Solution.SecondMethod
{
    public class CalculatorWithAbstractClass
    {
        public double CalculateAverage(ICollection<double> values, AbstractAveragingMethod averagingMethod)
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