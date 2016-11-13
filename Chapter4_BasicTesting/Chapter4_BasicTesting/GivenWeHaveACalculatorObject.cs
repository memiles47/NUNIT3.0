using NUnit.Framework;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    internal class GivenWeHaveACalculatorObject
    {
        private Calculator SUT { get; set; }

        [Test]
        [TestCase(3, 7, ExpectedResult = 10)]
        public int AddingTwoNumbersShouldReturncorrectSum(int a, int b)
        {
            // When I add 3 and 7 together
            var returnValue = SUT.Add(a, b);

            return returnValue;
        }
    }
}