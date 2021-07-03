using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Sequences
    {
        public static T[] FirstSequence<T>(int n)
        {
            dynamic lhs = 1;

            dynamic rhs = 1;

            T[] array = new T[n];

            array[0] = lhs; array[1] = rhs;

            dynamic c;

            for (int i = 2; i < n; i++) 
            {
                c = array[i - 2];
                array[i] = c + array[i - 1];
            }

            return array;
        }

        public static T[] SecondSequence<T>(int n)
        {
            dynamic lhs = 1;

            dynamic rhs = 2;

            T[] array = new T[n];

            array[0] = lhs; array[1] = rhs;

            dynamic a, b;

            for (int i = 2; i < n; i++)
            {
                a = array[i - 1];
                b = array[i - 2];
                array[i] = 6 * a - 8 * b;
            }

            return array;
        }

        public static T[] ThirdSequence<T>(int n)
        {
            dynamic lhs = 1.0;

            dynamic rhs = 2.0;

            T[] array = new T[n];

            array[0] = lhs; array[1] = rhs;

            dynamic a, b;

            for (int i = 2; i < n; i++)
            {
                a = array[i - 1];
                b = array[i - 2];
                array[i] = a + b / a;
            }

            return array;
        }

    }
}
