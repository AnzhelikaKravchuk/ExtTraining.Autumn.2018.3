using System;
using System.Collections.Generic;

namespace No6.Solution
{
    public class SequenceGenerator<T>
    {
        T FirstElement { get; }
        
        T SecondElement { get; }
        
        Func<T, T, T> NextElementRule { get; }
        
        public SequenceGenerator(T first, T second, Func<T, T, T> nextElementRule)
        {
            ThrowForInvalidParameters();
            
            this.FirstElement = first;
            this.SecondElement = second;
            this.NextElementRule = nextElementRule;

            void ThrowForInvalidParameters()
            {
                if (first == null)
                {
                    throw new ArgumentNullException(nameof(first));
                }
                
                if (second == null)
                {
                    throw new ArgumentNullException(nameof(second));
                }
                
                if (nextElementRule == null)
                {
                    throw new ArgumentNullException(nameof(nextElementRule));
                }
            }
        }

        public IEnumerable<T> GenerateSequenece(int amountOfElements)
        {
            if (amountOfElements < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amountOfElements));
            }

            return InnerGenerator();

            IEnumerable<T> InnerGenerator()
            {
                T a = this.FirstElement;
                T b = this.SecondElement;
                while (amountOfElements > 0)
                {
                    yield return a;

                    T temp = a;
                    a = b;
                    b = this.NextElementRule(b, temp);

                    amountOfElements--;
                }
            }
        }
    }
}























