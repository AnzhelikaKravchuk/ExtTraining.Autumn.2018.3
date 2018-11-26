using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Generate<T>(int count, Func<T, T, T> function, T first, T second)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(count)} must be positive");
            }

            IEnumerable<T> Calculate()
            {
                T current = first;
                T next = second;

                while (count-- > 0)
                {
                    yield return current;
                    var last = current;
                    current = next;
                    next = function(last, current);                   
                }
            }

            return Calculate();
        }
    }
}
