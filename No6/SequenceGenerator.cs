using System;
using System.Collections.Generic;

namespace No6
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> Generate<T>(int count, T firstElement, T secondElement, Func<T, T, T> nextElement)
        {

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (nextElement == null)
            {
                throw new ArgumentNullException(nameof(nextElement));
            }

            return GenerateCore();

            IEnumerable<T> GenerateCore()
            {
                T current = firstElement;
                T next = secondElement;

                for (int i = 0; i < count; ++i)
                {
                    yield return current;
                    Swap(ref current, ref next);
                    next = nextElement.Invoke(next, current);
                }
            }
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            var temp = x;
            x = y;
            y = temp;
        }
    }
}