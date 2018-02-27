using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsTest2;

namespace JenkinsTestTest
{
    [TestClass]
    public class JustWriteTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("This is a test.", JustWrite.GetMessage());
        }
    }
}
