using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator<T>
    {
        public static IEnumerable<T> SequnceEnumerable(T a, T b, int n, Func<T, T, T> rule)
        {
            if (n < 0)
            {
                throw new ArgumentException($"{nameof(n)} can't be less than 0");
            }

            return n == 0 ? null : Sequence(a, b, n, rule);
        }

        private static IEnumerable<T> Sequence(T a, T b, int n, Func<T, T, T> rule)
        {
            var prev = a;
            var next = b;

            for (int i = 0; i < n; i++)
            {
                yield return prev;
                var tmp = rule.Invoke(next, prev);
                prev = next;
                next = tmp;
            }
        }
    }
}
