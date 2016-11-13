using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chapter4_BasicTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_BasicTesting.Tests
{
    [TestClass()]
    public class SetupAndTeardownTests
    {
        [TestMethod()]
        public void OneTimeSetUpTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void OneTimeTearDownTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetupTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TearDownTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void Test1Test()
        {
            Assert.Fail();
        }

        public void Test2Test()
        {

        }
    }
}