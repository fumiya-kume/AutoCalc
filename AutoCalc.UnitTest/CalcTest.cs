using System;
using AutoCalc.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoCalc.UnitTest
{
    [TestClass]
    public class CalcTest
    {
        private CalcModel CalcModel => new CalcModel();

        [TestMethod]
        public void AddTest()
        {
            CalcModel.Push(1);
            CalcModel.Push(2);
            CalcModel.Add();
            Assert.AreEqual(CalcModel.CalcValue.Value,3);

        }
    }
}
