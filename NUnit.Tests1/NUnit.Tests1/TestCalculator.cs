// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NLog;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestCalculator
    {
        LoggerClass addLog = new LoggerClass();
        Calculator.Methods temp = new Calculator.Methods();
        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TesCalculatorAdd(double x, double y)
        {                                                                                          
            addLog.expected = x + y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "+");
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong addition. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TesCalculatorDiff(double x, double y)
        {
            addLog.expected = x - y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "-");
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong difference. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TesCalculatorDiv(double x, double y)
        {
            addLog.expected = x / y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "/");
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong division. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TesCalculatorMult(double x, double y)
        {
            addLog.expected = x * y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "*");
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong multiplication. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }
    }
}