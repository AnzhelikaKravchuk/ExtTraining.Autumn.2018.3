using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        public T CalculateAverage<T>(IEnumerable<T> values, Func<IEnumerable<T>, T> func)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (func==null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            return func(values);
        }

        public T CalculateAverage<T>(IEnumerable<T> values, IAverageFunc<T> func)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return CalculateAverage(values,func.Avegage);
        }

        public static double Mean(IEnumerable<double> values)
        {
            return values.Sum() / values.ToArray().Length;
        }

        public static double Median(IEnumerable<double> values)
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



