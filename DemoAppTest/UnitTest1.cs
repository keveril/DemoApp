using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1,1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("DemoApp", "DemoApp");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("DemoApp2", "DemoApp2");
        }
    }
}
