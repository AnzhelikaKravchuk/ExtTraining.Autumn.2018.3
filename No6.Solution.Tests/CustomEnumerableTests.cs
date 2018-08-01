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
            FunctionData<int> temp = new FunctionData<int>(1, 1, (x, y) => x + y);

            int[] actual = SequenceGenerator<int>.Generate(temp).ToArray();

            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            FunctionData<int> temp = new FunctionData<int>(1, 2, (x, y) => 6 * y - 8 * x);

            int[] actual = SequenceGenerator<int>.Generate(temp).ToArray();

            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            FunctionData<double> temp = new FunctionData<double>(1, 2, (x, y) => y + x / y);

            double[] actual = SequenceGenerator<double>.Generate(temp).ToArray();

            double[] expected =
                {
                    1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587,
                    7.42763417076325, 8.31053343902137
                };

            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(actual[i], expected[i], 0.000000000001);
            }
        }
    }
}
