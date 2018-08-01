using System;
using System.Collections.Generic;

namespace No6
{
    public static class SequenceGenerator<T>
    {
        public static IEnumerable<T> Generate(FunctionData<T> data, int amount = 10)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            return Generator(data, amount);
        }

        private static IEnumerable<T> Generator(FunctionData<T> data, int amount)
        {
            var current = data.FirstElement;
            var next = data.SecondElement;

            while (amount > 0)
            {
                amount--;
                yield return current;

                T temp = data.Function(current, next);
                current = next;
                next = temp;
            }
        }
    }
}