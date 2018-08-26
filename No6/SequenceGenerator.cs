using System;
using System.Collections.Generic;

namespace No6
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> Generate<T>(T firstElement, T secondElement, int n, Func<T, T, T> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            yield return firstElement;
            yield return secondElement;

            T value;

            if (n > 2)
            {
                while (n > 0)
                {
                    value = func(secondElement, firstElement);

                    yield return value;

                    firstElement = secondElement;
                    secondElement = value;

                    n--;
                }
            }
        }
    }
}
