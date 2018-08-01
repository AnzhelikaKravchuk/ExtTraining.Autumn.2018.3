using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            var generator = new GenerateNumbers<int>(10, (x, y) => y + x);
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            int[] actual = generator.StartGenerate(1, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            var generator = new GenerateNumbers<int>(10, (x, y) => 6 * y - 8 * x);
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] actual = generator.StartGenerate(1, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            var generator = new GenerateNumbers<int>(10, (x, y) => y + x / y);

            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            int[] actual = generator.StartGenerate(1, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}
