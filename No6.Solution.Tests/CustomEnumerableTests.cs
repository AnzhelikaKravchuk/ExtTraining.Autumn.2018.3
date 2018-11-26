﻿using System;
using System.Collections.Generic;
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
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            Func<int, int, int> func = (x, y) => y + x;

            CollectionAssert.AreEqual(expected, SequenceGenerator<int>.Generate(1, 1, 10, func).ToArray());
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Func<int, int, int> func = (x, y) => 6 * y - 8 * x;

            CollectionAssert.AreEqual(expected, SequenceGenerator<int>.Generate(1, 2, 10, func).ToArray());
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            Func<double, double, double> func = (x, y) => y + x / y;

            double[] actual = SequenceGenerator<double>.Generate(1, 2, 10, func).ToArray();

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.000001);
            }
        }
    }
}
