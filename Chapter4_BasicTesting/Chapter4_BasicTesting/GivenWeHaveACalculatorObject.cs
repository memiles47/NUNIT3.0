using NUnit.Framework;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    internal class GivenWeHaveACalculatorObject
    {
        //private Calculator SUT { get; set; }

        private readonly Calculator _sut = new Calculator();

        [Test]
        [TestCase(3, 7, ExpectedResult = 10)]
        public int AddingTwoNumbersShouldReturncorrectSum(int a, int b)
        {
            // When I add 3 and 7 together
            var returnValue = _sut.Add(a, b);

            return returnValue;
        }
    }
}