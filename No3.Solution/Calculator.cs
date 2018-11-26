using System;
using System.Collections.Generic;

/**
 * Предложено решение, где в методы CalculateAverage класса Calculator
 * можно передать логику нахождения среднего для значения среди вещественных чисел
 * Логику вычисления можно передать с помощью делегата или интерфейса
 */


namespace No3.Solution
{
    /// <summary>
    ///     Class calculates average value of <see cref="Double"/> numbers
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        ///     Calculates average value of <see cref="Double"/> numbers by <see cref="IAveragingCalculator{Double}"/>
        /// </summary>
        /// <param name="values"><see cref="Double"/> values</param>
        /// <param name="calculator"><see cref="IAveragingCalculator{Double}"/> calculator</param>
        /// <returns>Average value of source numbers</returns>
        /// <exception cref="ArgumentNullException">If values or calculator is null</exception>
        public static double CalculateAverage(IEnumerable<double> values, IAveragingCalculator<double> calculator)
        {
            if (values == null) throw  new ArgumentNullException(nameof(values));
            if (calculator == null) throw new ArgumentNullException(nameof(calculator));

            return CalculateAverage(values, calculator.Calculate);
        }

        /// <summary>
        ///     Calculates average value of <see cref="Double"/> numbers by <see cref="Func{IEnumerable{Double}, Double}"/> delegate
        /// </summary>
        /// <param name="values"><see cref="Double"/> values</param>
        /// <param name="calculator"><see cref="Func{IEnumerable{Double}, Double}"/> calculator</param>
        /// <returns>Average value of source numbers</returns>
        /// <exception cref="ArgumentNullException">If values or calculator is null</exception>
        public static double CalculateAverage(IEnumerable<double> values, Func<IEnumerable<double>, double> calculator)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (calculator == null) throw new ArgumentNullException(nameof(calculator));

            return calculator(values);
        }
    }
}
