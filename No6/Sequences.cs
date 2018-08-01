using System;
using System.Collections;
using System.Collections.Generic;

namespace No6
{
    public static class Sequences
    {
        public static T[] SequenceGenerator<T>(T a, T b, Func<T, T, T> func, int n)
        {
            T[] result = new T[n];
            result[0] = a;
            result[1] = b;

            for(int i = 2; i < n; i++)
            {
                result[i] = func(result[i - 1], result[i - 2]);
            }

            return result;
        }
    }
}
