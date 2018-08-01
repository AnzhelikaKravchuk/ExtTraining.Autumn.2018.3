using System;
using System.Collections.Generic;

namespace No6
{
    public static class SequenceGenerator <T>
    {
        public static IEnumerable<T> Generate(Func<T,T,T> func, T first, T second, int counter)
        {
            if (first == null || second == null)
            {
                throw new ArgumentNullException($"{first} or {second} can't be equal to null!");
            }

            if (counter < 2)
            {
                throw new ArgumentException($"{counter} can't be less than 2!");
            }

            return GenerateInner(func, first, second, counter);
        }

        private static IEnumerable<T> GenerateInner(Func<T, T, T> func, T first, T second, int counter)
        {
            yield return first;
            yield return second;

            for (int i = 2; i < counter; i++)
            {
                T value = func(first, second);
                yield return value;

                Swap(ref first, ref second, ref value);
            }
        }

        private static void Swap(ref T lhs, ref T rhs, ref T value)
        {
            lhs = rhs;
            rhs = value;
        }
    }
}
