using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter6_ManagingYourTests
{
    [TestFixture]

    public class OrderingTests
    {
        private static IEnumerable<TestCaseData> MainTests
        {
            {
                //Angie wants a car now
                //Angie has the money to get the car now
                //she also knows I won't be able to send her
                //money for a while.

                yield return new TestCaseData(new Action(() =>
                    {
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine("This is output 1");
                    }
                ));

                yield return new TestCaseData(new Action(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("This is output 2");
                }
                ));

                yield return new TestCaseData(new Action(() =>
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("This is output 3");
                }
                ));
            }
        }

        [Test]
        [TestCaseSource(nameof(MainTests))]
        public void TestRunner(Action func)
        {
            func();
        }
    }
}
