using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int quantity = 10;
            int a = 1, b = 1;
            int[] actual = new int[quantity];

            var generator = SequenceGenerator.Generator(10, 1, 1, (x, y) => x + y);

            int index = 0;

            foreach(int item in generator)
            {
                actual[index++] = item;
            }

            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int quantity = 10;
            int a = 1, b = 2;
            int[] actual = new int[quantity];

            var generator = SequenceGenerator.Generator(quantity, a, b, (x, y) => 6 * x - 8 * y);

            int index = 0;

            foreach (int item in generator)
            {
                actual[index++] = item;
            }

            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            int quantity = 10;
            double a = 1, b = 2;
            double[] actual = new double[quantity];

            var generator = SequenceGenerator.Generator(quantity, a, b, (x, y) => x + y / x);

            int index = 0;

            foreach (double item in generator)
            {
                actual[index++] = item;
            }

            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
