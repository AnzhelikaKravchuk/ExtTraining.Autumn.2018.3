using NUnit.Framework;
using No6.Solution;
using System;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        private const double Precision = 0.0001;


        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            int i = 0;

            foreach (var actual in SequenceGenerator<int>.Generate(1, 1, (first, second) =>second+first, 10))
            {
                Assert.AreEqual(expected[i], actual);
                i++;
            }

        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int i = 0;

            foreach (var actual in SequenceGenerator<int>.Generate(1, 2,(first,second) => 6 * second - 8 * first, 10))
            {
                Assert.AreEqual(expected[i], actual);
                i++;
            }
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            int i = 0;

            foreach (var actual in SequenceGenerator<double>.Generate(1, 2, (first,second) => second + first/second, 10))
            {
                Assert.AreEqual(expected[i],actual,Precision);
                i++;
            }
        }
    }
}
