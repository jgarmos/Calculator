using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add()
        {
            Calculator.Calculator calculator =  new Calculator.Calculator();
            int result = calculator.Add(2,2);
            Assert.AreEqual(4,result);
        }
        [TestMethod]
        public void AddWithDifferentsArguments()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            int result = calculator.Add(2, 5);
            Assert.AreEqual(7,result);
        }
    }
}
