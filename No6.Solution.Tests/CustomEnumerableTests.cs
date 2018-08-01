using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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

            var generator = new SequenceGenerator<int>(1, 1, (a, b) => a + b);

            var actual = generator.GenerateSequenece(expected.Length);
            
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            var generator = new SequenceGenerator<int>(1, 2, (a, b) => 6*a - 8*b);

            var actual = generator.GenerateSequenece(expected.Length);
            
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            var generator = new SequenceGenerator<double>(1, 2, (a, b) => a + b / a);

            var actual = generator.GenerateSequenece(expected.Length);
            
            CollectionAssert.AreEqual(expected, actual, Comparer<double>.Create((a, b) => a - b <= 0.000000001 ? 0 : 1));
        }

        [Test]
        public void Generator_ForSequence4()
        {
            int[] expected = { 2, 3, 7, 16, 65, 321, 4546, 107587, 20773703 };
            
            var generator = new SequenceGenerator<int>(2, 3, (a, b) => a + b*b);

            var actual = generator.GenerateSequenece(expected.Length);
            
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
