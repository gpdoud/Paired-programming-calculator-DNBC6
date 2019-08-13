using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibraryTest {

    [TestClass]
    public class CalcLibTest {

        int total = 0;

        [TestMethod]
        public void TestAdd() {
            // test -5
            total = CalculatorLibrary.CalcLib.Add(total, -5);
            Assert.AreEqual(-5, total);
            // test negative one
            total = CalculatorLibrary.CalcLib.Add(total, -1);
            Assert.AreEqual(-6, total);
            // test zero
            total = CalculatorLibrary.CalcLib.Add(total, 0);
            Assert.AreEqual(-6, total);
            // test one
            total = CalculatorLibrary.CalcLib.Add(total, 1);
            Assert.AreEqual(-5, total);
            // test 5
            total = CalculatorLibrary.CalcLib.Add(total, 5);
            Assert.AreEqual(0, total);
        }
        [TestMethod]
        public void TestSubtract() {
            // test -5
            total = CalculatorLibrary.CalcLib.Subtract(total, -5);
            Assert.AreEqual(5, total);
            // test negative one
            total = CalculatorLibrary.CalcLib.Subtract(total, -1);
            Assert.AreEqual(6, total);
            // test zero
            total = CalculatorLibrary.CalcLib.Subtract(total, 0);
            Assert.AreEqual(6, total);
            // test one
            total = CalculatorLibrary.CalcLib.Subtract(total, 1);
            Assert.AreEqual(5, total);
            // test 5
            total = CalculatorLibrary.CalcLib.Subtract(total, 5);
            Assert.AreEqual(0, total);
        }
        [TestMethod]
        public void TestMultiply() {
            // init to 1
            total = CalculatorLibrary.CalcLib.Add(total, 1);
            // test -5
            total = CalculatorLibrary.CalcLib.Multiply(total, -5);
            Assert.AreEqual(-5, total);
            // test negative one
            total = CalculatorLibrary.CalcLib.Multiply(total, -1);
            Assert.AreEqual(5, total);
            // test zero
            total = CalculatorLibrary.CalcLib.Multiply(total, 0);
            Assert.AreEqual(0, total);
            // init to 1
            total = CalculatorLibrary.CalcLib.Add(total, 1);
            // test one
            total = CalculatorLibrary.CalcLib.Multiply(total, 1);
            Assert.AreEqual(1, total);
            // test 5
            total = CalculatorLibrary.CalcLib.Multiply(total, 5);
            Assert.AreEqual(5, total);
        }
        [ExpectedException(typeof(DivideByZeroException))]
        [TestMethod]
        public void TestDivide() {
            // init to 100
            total = CalculatorLibrary.CalcLib.Add(total, 100);
            // test -5
            total = CalculatorLibrary.CalcLib.Divide(total, -5);
            Assert.AreEqual(-20, total);
            // test negative one
            total = CalculatorLibrary.CalcLib.Divide(total, -1);
            Assert.AreEqual(20, total);
            // test one
            total = CalculatorLibrary.CalcLib.Divide(total, 1);
            Assert.AreEqual(20, total);
            // test 5
            total = CalculatorLibrary.CalcLib.Divide(total, 5);
            Assert.AreEqual(4, total);
            // test zero
            total = CalculatorLibrary.CalcLib.Divide(total, 0);
            Assert.AreEqual(6, total);
        }
    }
}
