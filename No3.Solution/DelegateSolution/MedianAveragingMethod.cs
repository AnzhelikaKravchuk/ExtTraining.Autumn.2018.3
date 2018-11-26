using System;
using System.Linq;
using System.Collections.Generic;

namespace No3.Solution.DelegateSolution
{
    /// <summary>
    /// Describes median average method
    /// </summary>
    public class MedianAveragingMethod : IAveragingMethod
    {
        /// <summary>
        /// Calculates average for values
        /// </summary>
        /// <param name="values">Values</param>
        /// <returns>Average for value</returns>
        public double Average(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
