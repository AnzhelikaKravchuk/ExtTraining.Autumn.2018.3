using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.Tests.FirstMethod
{
    public class Mean : IAveragingMethod
    {
        public double FindAverage(ICollection<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Count == 0)
            {
                throw new ArgumentException("Can not calculate mean of empty collection.");
            }
            
            return values.Sum() / values.Count;  
        } 
    }
}