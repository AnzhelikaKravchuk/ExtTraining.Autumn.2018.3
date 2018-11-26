using System;
using System.Linq;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var result = GenericGenerator.Generator(1, 1, (i, i1) => i + i1);
            Assert.AreEqual(expected, result.Take(10));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            var result = GenericGenerator.Generator(1, 2, (i, i1) => 6 * i1 - 8 * i);
            Assert.AreEqual(expected, result.Take(10));
        }

        [Test]
        [DefaultFloatingPointTolerance(0.000001)]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            var result = GenericGenerator.Generator<double>(1, 2, (i, i1) => i1 + i / i1).Take(10);
            Assert.AreEqual(expected, result);
        }
    }
}
