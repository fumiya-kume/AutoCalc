using System;
using AutoCalc.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoCalc.UnitTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(CalcModel.Add(1, 2), 3);
            Assert.AreEqual(CalcModel.Add(2, 3), 5);
        }
    }
}
