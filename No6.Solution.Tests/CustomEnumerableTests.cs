using NUnit.Framework;
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
            IEnumerable<int> list = NumericGenerator<int>.Generate(new FirstGenerator(), 10);
            CollectionAssert.AreEqual(expected, list);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            IEnumerable<int> list = NumericGenerator<int>.Generate(new SecondGenerator(), 10);
            CollectionAssert.AreEqual(expected, list);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            IEnumerable<double> list = NumericGenerator<double>.Generate(new ThirdGenerator(), 10);

            int i = 0;

            foreach (double value in list)
            {
                Assert.AreEqual(expected[i], value, 0.01);
                i++;
            }
        }
    }
}
