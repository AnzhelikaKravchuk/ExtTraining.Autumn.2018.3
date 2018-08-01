using System;
using System.Collections.Generic;

namespace No3.Solution.SecondMethod
{
    public abstract class AbstractAveragingMethod
    {
        public double Calculate(ICollection<double> values)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }
            
            if (values.Count == 0)
            {
                throw new ArgumentException("Can not calculate mean of empty collection.");
            }
            
            return FindAverage(values);
        }

        public abstract double FindAverage(ICollection<double> values);
    }
}