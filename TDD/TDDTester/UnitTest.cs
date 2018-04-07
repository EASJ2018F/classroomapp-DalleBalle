
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringCalculator calculator = new StringCalculator();
            string input = "";

            int result = calculator.Add(input);

            Assert.AreEqual(0, result);
        }
    }
}
