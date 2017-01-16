using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chapter6_ManagingYourTests
{
    [TestFixture]

    public class OrderingTests
    {
        public static IEnumerable<TestCaseData> MainTests
        {
            //testing Day 25
            //Bike seat came yesterday, padded under as well.
            //Subscription was set up and I can ride this afternoon
            //I rode the grand tetons for 15 minutes. Hard.....
            //I made 7 rides this weekend
            get
            {
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
