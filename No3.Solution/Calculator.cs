using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    /// <summary>
    /// Calculate average
    /// </summary>
    public class Calculator
    {
        public delegate double Calculate(List<double> values);
        
        /// <summary>
        /// Calculate average by using Interface
        /// </summary>
        /// <param name="values"></param>
        /// <param name="average"></param>
        /// <returns></returns>
        public double CalculateAverage(List<double> values, IAverage average)
        {
            if (values == null)
            {
                throw new ArgumentNullException("List of values can't be null!");
            }
            if (average == null)
            {
                throw new ArgumentNullException("Interface member can't be null!");
            }

            return average.Calculate(values);
        }

        /// <summary>
        /// Calculate average by using delegate
        /// </summary>
        /// <param name="values"></param>
        /// <param name="calculate"></param>
        /// <returns></returns>
        public double CalculateAverage(List<double> values, Calculate calculate)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return calculate(values);
        }
    }
}
