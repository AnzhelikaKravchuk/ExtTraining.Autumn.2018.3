using System;
using System.Collections.Generic;
using System.Linq;

/**
 * Был создан статический клас с обобщенным методом генерации последовательности,
 * который принимает логику вычисления следующего элемента, начиная с третьего.
 * Целевой метод делегата требует значения двух первых элементов последовательностти
 * и номер элемента, который нужно вычислить.
 */

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Generate<T>(T number1, T number2, Func<int, T, T, T> nextNumberGenerator,
            int count)
        {
            if (nextNumberGenerator == null) throw new ArgumentNullException(nameof(nextNumberGenerator));
            if (count < 0) throw new ArgumentException();

            return count == 0 ? Enumerable.Empty<T>() : GenerateWithoutCheck(number1, number2, nextNumberGenerator, count);
        }

        private static IEnumerable<T> GenerateWithoutCheck<T>(T number1, T number2, Func<int, T, T, T> nextNumberGenerator, int count)
        {
            yield return number1;

            if (count == 1) yield break;

            yield return number2;

            if (count == 1) yield break;

            for (var n = 3; n <= count; n++)
            {
                yield return nextNumberGenerator(n, number1, number2);
            }
        }
    }
}