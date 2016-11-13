using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    internal class CalculatorTest
    {
        [Test]
        public void AddShouldReturnSumOfTwoNumbers()
        {
            // Given that we have a calculator
            var sut = new Calculator();

            // When I add 3 and 7 together
            var returnValue = sut.add(3, 7);

            // Then the result should be 10
            Assert.That(returnValue, Is.EqualTo(10));
        }
    }
}
