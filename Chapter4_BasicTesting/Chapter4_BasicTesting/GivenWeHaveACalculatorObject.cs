using System;
using NUnit.Framework;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    internal class GivenWeHaveACalculatorObject
    {
        Calculator Sut { get; } = new Calculator();

        [Test]
        [TestCase(3, 7, ExpectedResult = 10)]
        public int AddingTwoNumbersShouldReturncorrectSum(int a, int b)
        {
            // When I add 3 and 7 together
            var returnValue = Sut.Add(a, b);
            return returnValue;
        }

        [Test]
        public void AddingOneToMaxValueThrowsAnException()
        {
            var exception = Assert.Catch(() => Sut.Add(int.MaxValue, 1));
            Assert.That(exception, Is.TypeOf<OverflowException>());
        }
    }
}