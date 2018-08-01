using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null || averagingMethod == null)
            {
                throw  new ArgumentNullException("Check your data!");
            }

            return averagingMethod.Calculate(values);
        }
    }
}
