using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Generate<T>(T first, T second, Func<T, T, T> function, int count)
        {
            if (count < 1)
            {
                throw new ArgumentException($"{nameof(count)} need to be positive.");
            }

            return GenerateCore(count);

            IEnumerable<T> GenerateCore(int number)
            {
                yield return first;
                yield return second;
                for (var i = 2; i < number; i++)
                {
                    T next = function(first, second);
                    first = second;
                    second = next;
                    yield return next;
                }
            }
        }
    }
}
