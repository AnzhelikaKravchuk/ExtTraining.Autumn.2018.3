using System.Collections.Generic;

namespace No3.Solution
{
    /// <summary>
    ///     Defines Calculate method for <see cref="IEnumerable{T}"/>
    /// </summary>
    public interface IAveragingCalculator<T>
    {
        /// <summary>
        ///     Calculates something for <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <param name="numbers">Items</param>
        /// <returns>Result of calculation</returns>
        T Calculate(IEnumerable<T> numbers);
    }
}