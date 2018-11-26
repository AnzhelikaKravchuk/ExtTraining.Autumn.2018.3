using System;
using System.Collections.Generic;

namespace No3.Solution.InterfaceSolution
{
    public class Calculator
    {
        /// <summary>
        /// Calculates average for value using averaging method of IAveragingMethod interface
        /// </summary>
        /// <param name="values">Values</param>
        /// <param name="averagingMethod">IAveragingMethod interface instance</param>
        /// <returns>Average for values</returns>
        public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.Average(values);           
        }

        /// <summary>
        /// Calculates average for value using delegate
        /// </summary>
        /// <param name="values">Value</param>
        /// <param name="averagingMethod">Delegate encapsulating logic of average calculating method</param>
        /// <returns>Average</returns>
        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod)
        {
            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return CalculateAverage(values, new DelegateToInterfaceAdapter(averagingMethod));
        }
    }
}
