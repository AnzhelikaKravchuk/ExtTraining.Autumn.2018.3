using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

           var result =  SequenceGenerator.Generate(expected.Length, 1, 1, (x, y) => x + y);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            var result = SequenceGenerator.Generate(expected.Length, 1, 2, (x, y) => 6 * y - 8 * x);

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var result = SequenceGenerator.Generate(expected.Length, 1d, 2d, (x, y) => y + x/y).ToArray();

            for (int i = 0; i < result.Length; ++i)
            {
                if (Math.Abs(result[i] - expected[i]) < 0.0000000000001)
                {
                    Assert.False(false);
                }
            }
            
           Assert.True(true);
        }
    }
}
