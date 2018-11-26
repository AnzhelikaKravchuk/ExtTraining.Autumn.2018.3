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
            Generator<int> generator = new Generator<int>((a, b) => a + b);
            int first = 1;
            int second = 1;
            int count = 10;

            int[] actual = generator.Generate(count, first, second).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            Generator<int> generator = new Generator<int>((a, b) => 6 * a - 8 * b);
            int first = 1;
            int second = 2;
            int count = 10;

            int[] actual = generator.Generate(count, first, second).ToArray();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            Generator<double> generator = new Generator<double>((a, b) => a + b / a);
            double first = 1;
            double second = 2;
            int count = 10;

            double[] actual = generator.Generate(count, first, second).ToArray();

            Assert.That(actual, Is.EqualTo(expected).Within(0.01));
        }
    }
}
