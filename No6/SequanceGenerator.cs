using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace No6.Solution
{
    public static class SequanceGenerator<T>
    {
        /// <summary>
        /// Generates the specified first.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <param name="length">The length.</param>
        /// <param name="generateNext">The generate next.</param>
        /// <returns>sequance</returns>
        /// <exception cref="ArgumentException">length</exception>
        public static IEnumerable<T> Generate(T first, T second, int length, Func<T,T,T> generateNext)
        {
            Validate(first);
            Validate(second);
            if (length <= 2)
            {
                throw new ArgumentException(nameof(length));
            }

            IEnumerable<T> Calculate()
            {
                yield return first;
                yield return second;
                length -= 2;
                T next = generateNext(second, first);
                T prev = second;
                while (length-- > 0)
                {
                    yield return next;
                    var tempValue = next;
                    next = generateNext(next, prev);
                    prev = tempValue;
                }
            }

            return Calculate();           
        }

        private static void Validate(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
        }
    }
}
