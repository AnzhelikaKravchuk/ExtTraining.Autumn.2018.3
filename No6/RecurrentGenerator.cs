using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class RecurrentGenerator
    {
        public static IEnumerable<T> Generate<T>(int n, Func<T, T, T> func, T first, T second)
        {
            if (n <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(n)} must be positive");
            }

            IEnumerable<T> Find()
            {
                (T a, T b) = (first, second);

                while (n-- > 0)
                {
                    yield return a;
                    (a, b) = (b, func(a, b));
                }
            }

            return Find();
        }
    }
}
