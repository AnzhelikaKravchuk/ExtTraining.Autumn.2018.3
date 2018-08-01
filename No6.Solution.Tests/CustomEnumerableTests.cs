using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using No6.Solution;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            List<int> result = SequanceGenerator<int>.Generate(1, 1, 10, (a, b) => a + b).ToList();
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            List<int> result = SequanceGenerator<int>.
                Generate(1, 2, 10, (a, b) => 6 * a - 8 * b).ToList();
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            List<double> result = SequanceGenerator<double>.
                Generate(1, 2, 10, (a, b) => a + b / a).ToList();
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.0000001);
            }
        }
    }
}
