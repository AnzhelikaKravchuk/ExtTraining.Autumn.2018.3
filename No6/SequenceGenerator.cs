using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> GenerateSequence<T>(int n,T first,T second,Func<T,T,T> func)
        {
            if (n <= 0)
            {
                throw new ArgumentException($"{nameof(n)} can't be non-positive");
            }

            T fib1 = first, fib2 = second, sum = default(T);

            IEnumerable<T> GenerateSequence()
            {
                yield return fib1;

                if (n == 1)
                {
                    yield break;
                }

                yield return fib2;

                int i = 2;

                while (i < n)
                {
                    yield return sum = func(fib1,fib2);
                    fib1 = fib2;
                    fib2 = sum;
                    i++;
                }
            }

            return GenerateSequence();

        }
    }
}
