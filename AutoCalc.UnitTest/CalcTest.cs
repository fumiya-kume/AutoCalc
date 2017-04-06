using System;
using AutoCalc.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoCalc.UnitTest
{
    [TestClass]
    public class CalcTest
    {
        private static CalcModel CalcModel => new CalcModel();

        [TestMethod]
        public void 足し算のテスト()
        {
            var Calc= CalcModel;
            Calc.Push(1);
            Calc.Push(2);
            Calc.Add();
            Calc.Result();
            Assert.AreEqual(Calc.CalcValue.Value,3);
        }

        [TestMethod]
        public void 引き算のテスト()
        {
            var Calc = CalcModel;
            Calc.Push(3);
            Calc.Push(1);
            Calc.Sub();
            Calc.Result();
            Assert.AreEqual(Calc.CalcValue.Value,2);
        }
    }
}
