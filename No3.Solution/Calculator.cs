using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    /*
     * Метод CalculateAverage принимает последовательность чисел и стратегию нахождения среднего арифметического.
     */
    public class Calculator
    {
        public double CalculateAverage(List<double> values, Func<List<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException($"{nameof(values)} need to be not null.");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"{nameof(averagingMethod)} need to be not null.");
            }

            return averagingMethod.Invoke(values);
        }

        public double CalculateAverage(List<double> values, IAverage averagingMethod)
        {
            if (averagingMethod == null)
            {
                throw new ArgumentNullException($"{nameof(averagingMethod)} need to be not null.");
            }

            return CalculateAverage(values, averagingMethod.Average);
        }
    }
}
