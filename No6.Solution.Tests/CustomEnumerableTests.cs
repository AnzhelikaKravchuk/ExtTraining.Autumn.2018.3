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

            SequenceGenerator<int> generator = new SequenceGenerator<int>();

            int[] actual = generator.Generate(10, 1, 1, Method1Int);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            SequenceGenerator<int> generator = new SequenceGenerator<int>();

            int[] actual = generator.Generate(10, 1, 2, Method2Int);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            SequenceGenerator<double> generator = new SequenceGenerator<double>();

            double[] actual = generator.Generate(10, 1, 2, Method3Double);

            for(int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i], 0.000001);
            }
        }

        public int Method1Int(int first, int second)
        {
            return first + second;
        }

        public double MethodDouble(double first, double second)
        {
            return first + second;
        }

        public int Method2Int(int first, int second)
        {
            return 6 * second - 8 * first;
        }

        public double Method2Double(double first, double second)
        {
            return 6 * second - 8 * first;
        }

        public int Method3Int(int first, int second)
        {
            return second + first / second;
        }

        public double Method3Double(double first, double second)
        {
            return second + first / second;
        }
    }
}
