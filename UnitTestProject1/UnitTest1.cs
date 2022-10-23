using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form1 = new Form1();
            float a = 2;
            string dis = "2";
            string ext = "4";
            string result = form1.calculate(a,dis,1);
            Assert.AreEqual(ext, result, "Eror!");

        }
    }
}
