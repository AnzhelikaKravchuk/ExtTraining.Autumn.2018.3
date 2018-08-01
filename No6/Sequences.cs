using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6.Solution.Tests
{
    public static class Sequences
    {
        public static IEnumerable<T> GenerateFirstSequence<T>(int number)
        {
            T[] array = new T[number];
            var first = 1;
            var second = 1;

            T NextNumber()
            {
                var nextNumber = (dynamic)first + (dynamic)second;
                first = second;
                second = nextNumber;
                return nextNumber;
            }

            for (int i = 0; i < number; i++)
            {
                yield return (dynamic)first;
                NextNumber();
            }
        }
        //Хотел сделать yeld, но что-то пошло не так
        public static IEnumerable<T> GenerateSecondSequence<T>(int number)
        {
            T[] array = new T[number];
            array[0] = (dynamic)1;
            array[1] = (dynamic)2;

            dynamic a, b;

            for (int i = 2; i < number; i++)
            {
                
            }
            return array;
        }

    }
}
