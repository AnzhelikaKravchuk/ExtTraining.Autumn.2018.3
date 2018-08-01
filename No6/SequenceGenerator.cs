using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator
    {
        public static T[] SequenceN1<T>(int n) => FindSequence<T>(Sequences.FirstSequence<T>, n);

        public static T[] SequenceN2<T>(int n) => FindSequence<T>(Sequences.SecondSequence<T>, n);

        public static T[] SequenceN3<T>(int n) => FindSequence<T>(Sequences.ThirdSequence<T>, n);

        private static T[] FindSequence<T>(Delegate.FindEnum<T> find, int n)
        {
            return find(n);
        }
    }
}
