using System.Collections.Generic;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            IEnumerable<int> actual = SequenceGenerator<int>.SequnceEnumerable(1, 1, expected.Length, (x, y) => x + y);

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            IEnumerable<int> actual = SequenceGenerator<int>.SequnceEnumerable(1, 2, expected.Length, (x, y) => 6 * x - 8 * y);

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            IEnumerable<double> actual = SequenceGenerator<double>.SequnceEnumerable(1, 2, expected.Length, (x, y) => x + y / x);

            int i = 0;
            foreach (var item in actual)
            {
                Assert.AreEqual(expected[i++], item, 0.00000000000001);
            }
        }
    }
}
