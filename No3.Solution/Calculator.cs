using System;
using System.Collections.Generic;

namespace No3.Solution
{
    /*
     * Возможным вариантом также является передавать в качестве параметра вместо делегата объект интерфейса. Затем нужный метод этого объекта передавать
     * в качестве параметра в метод, принимающий делегат, таким образом логика будет находится в одном методе, а возможности обращения к нему расширятся.
     */
    public class Calculator
    {
         public double CalculateAverage(IEnumerable<double> values, Func<IEnumerable<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values) + "must not be null");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod) + "must not be null");
            }

            return averagingMethod.Invoke(values);
        }
    }
}
