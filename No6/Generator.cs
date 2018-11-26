using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    class Generator
    {
        public static IEnumerable<T> Generate<T>(T firstElement, T secondElement, Func<T,T,T> formula, int lengthOfSequence)
        {
            if (lengthOfSequence <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(lengthOfSequence));
            }

            return GenerateSequence();

            IEnumerable<T> GenerateSequence()
            {
                yield return firstElement;
                yield return secondElement;

                

                for (int i = 0; i < lengthOfSequence; i++)
                {
                    T next = formula(firstElement, secondElement);
                    firstElement = secondElement;
                    secondElement = next;

                    yield return next;
                }
            }
        }

        private void InputValidation(int length)
        {
            
        }
    }
}
