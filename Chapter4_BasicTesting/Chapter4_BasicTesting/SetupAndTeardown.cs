using System;
using NUnit.Framework;

namespace Chapter4_BasicTesting
{
    [TestFixture]
    public class SetupAndTeardown
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("This runs once before all of the tests in this test fixture");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("This runs once after all of the testx in this test fixture");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This runs before each test in this test fixture");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("This runs after each test in this test fixture");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("This is inside Test 1");
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("This is inside Test 2");
        }
    }
}
