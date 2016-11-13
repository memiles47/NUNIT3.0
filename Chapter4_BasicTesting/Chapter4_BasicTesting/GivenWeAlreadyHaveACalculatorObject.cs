using NUnit.Framework;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    internal class GivenWeAlreadyHaveACalculatorObject
    {
        private Calculator Calculator { get; set; }

        [SetUp]
        public void Setup()
        {
            Calculator = new Calculator();
        }

        [Test]
        public void AddingTwoNumbersShouldReturncorrectSum()
        {
            // When I add 3 and 7 together
            var returnValue = Calculator.add(3, 7);

            // Then the result should be 10
            Assert.That(returnValue, Is.EqualTo(10));
        }
    }
}
