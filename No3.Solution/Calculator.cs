using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    // Идея заключается в использовании паттерна стратегия
    // присутствуют 2 реализации публичного api с делегатом и интерфейсом
    // Необходимость замыкания делегата на интерфейс отсутствует, т.к. метод интерфейса
    // или делегата полностью инкапсулирует логику вычисления average
    public static class Calculator
    {
        public static double CalculateAverage(this IEnumerable<double> values,IAverage averagingMethod)
        {
            if (values is null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            if (averagingMethod is null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.Average(values);
        }

        public static double CalculateAverage(this IEnumerable<double> values,Func<IEnumerable<double>,double> averagingMethod)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod is null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod(values);
        }

    }
}
