using System;
using System.Linq;
using System.Collections.Generic;

namespace No3.Solution.DelegateSolution
{
    /// <summary>
    /// Describes mean average method
    /// </summary>
    public class MeanAveraginMethod : IAveragingMethod
    {
        /// <summary>
        /// Calculates average for values
        /// </summary>
        /// <param name="values">Values</param>
        /// <returns>Average for value</returns>
        public double Average(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
