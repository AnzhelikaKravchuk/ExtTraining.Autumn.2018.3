using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class FirstGenerator: IGenarator<int>
    {
        // Squence: x(n + 1) = x(n) +  x(n - 1)
        // Result: {1, 1, 2, 3, 5, 8, 13, 21, 34, 55}

        public IEnumerable<int> Generate(int sequenceLength)
        {
            yield return 1;
            yield return 1;

            int prev = 1;
            int current = 1;
            int next;

            for (int i = 0; i < sequenceLength - 2; i++)
            {
                yield return next = prev + current;
                prev = current;
                current = next;
            }

        }
    }
}
