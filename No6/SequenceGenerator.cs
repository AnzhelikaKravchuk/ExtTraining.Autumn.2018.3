using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator<T>
    {
        public static IEnumerable<T> Generate(T firstMember,T secondMember,Func<T,T,T> functionOfTwoVariables,int desiredLengthOfSequence)
        {
            if(desiredLengthOfSequence <= 2)
            {
                throw new ArgumentOutOfRangeException("Length of sequence must be greater than 2 or equals 2" + nameof(desiredLengthOfSequence));
            }

            if(functionOfTwoVariables is null)
            {
                throw new ArgumentNullException("Function can't be null" + nameof(functionOfTwoVariables));
            }

            return Generate();

            IEnumerable<T> Generate()
            {
                yield return firstMember;
                yield return secondMember;

                T previous = firstMember;
                T current = secondMember;
                T next;

                while (desiredLengthOfSequence - 2 > 0)
                {
                    next = functionOfTwoVariables(previous, current);

                    yield return next;

                    previous = current;
                    current = next;
                    desiredLengthOfSequence--;
                }
            }

        }
    }
}
