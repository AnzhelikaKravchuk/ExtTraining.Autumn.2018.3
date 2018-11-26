using System;
using System.Collections.Generic;
using System.Linq;

namespace No6
{
    public static class SequenceGenerator
    {
        /// <summary>
        /// Generates sequence using specified member calculating algorithm
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="quantity">Quantity</param>
        /// <param name="a">A</param>
        /// <param name="b">B</param>
        /// <param name="func">Algorithm</param>
        /// <returns>Enumerator for sequence</returns>
        public static IEnumerable<T> Generator<T>(int quantity, T a, T b, Func<T, T, T> func)
        {
            if (quantity < 0)
            {
                throw new ArgumentException($"Value of {nameof(quantity)} must be non-negative");
            }

            return GeneratorCore(quantity, a, b, func);
        }

        private static IEnumerable<T> GeneratorCore<T>(int quantity, T a, T b, Func<T, T, T> func)
        {
            for (int i = 0; i < quantity; ++i)
            {
                yield return GetNextElement(i);
            }

            T GetNextElement(int index)
            {
                if (index == 0) return a;
                if (index == 1) return b;
                return func(GetNextElement(index - 1), GetNextElement(index - 2));
            }
        }
    }
}
