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

            Assert.AreEqual(expected, Generator.Generate(1, 1, (first, second) => (second + first), 10));
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Assert.AreEqual(expected, Generator.Generate(1, 2, (first, second) => (6 * second - 8 * first), 10));
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            var actual = Generator.Generate<double>(1, 2, (first, second) => (second + first / second), 10).ToArray();
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.00000000001);
            }
        }
    }
}
