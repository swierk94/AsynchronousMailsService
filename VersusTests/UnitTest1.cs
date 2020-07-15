using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VersusTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            int a;
            int b;
            //act
            a = 1;
            b = 1;

            //assert
            Assert.AreEqual(a,b);
        }
    }
}
