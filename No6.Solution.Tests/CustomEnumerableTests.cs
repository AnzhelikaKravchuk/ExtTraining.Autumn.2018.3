using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

			var generator = new SequenceGenerator<int>(1, 1, (a, b) => a + b);

			CollectionAssert.AreEqual(generator.Generate(10), expected);
        }

		[Test]
		public void Generator_ForSequence2()
		{
			int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

			var generator = new SequenceGenerator<int>(1, 2, (a, b) => 6 * a - 8 * b);

			CollectionAssert.AreEqual(generator.Generate(10), expected);
		}

		[Test]
		public void Generator_ForSequence3()
		{
			double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

			var generator = new SequenceGenerator<double>(1, 2, (a, b) => a + b / a);

			CollectionAssert.AreEqual(generator.Generate(10), expected, Comparer<double>.Create((a, b) => Math.Abs(a - b) <= 0.000000001 ? 0 : 1));
		}
	}
}
