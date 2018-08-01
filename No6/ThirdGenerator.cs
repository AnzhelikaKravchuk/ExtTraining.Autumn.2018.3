using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class ThirdGenerator : IGenarator<double>
    {
        // Squence: x(n + 1) = x(n) +  x(n - 1) / x(n)
        // Result: { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

        public IEnumerable<double> Generate(int sequenceLength)
        {
            yield return 1;
            yield return 2;

            double prev = 1;
            double current = 2;
            double next;

            for (int i = 0; i < sequenceLength - 2; i++)
            {
                yield return next = current + prev / current;
                prev = current;
                current = next;
            }

        }
    }
}
