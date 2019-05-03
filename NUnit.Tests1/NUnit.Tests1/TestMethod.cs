// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NLog;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestMethod
    {
        LoggerClass addLog = new LoggerClass();
        Calculator.Methods temp = new Calculator.Methods();
        [Test]
        [TestCaseSource(typeof(DataSource), "DataTest")]
        public void TestMethodAdd(double x, double y)
        {
            addLog.expected = x + y;
            addLog.actual = temp.addition(x, y);
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong addition. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodDiff(double x, double y)
        {
            addLog.expected = x - y;
            addLog.actual = temp.difference(x, y);
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong difference. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodDiv(double x, double y)
        {
            addLog.expected = x / y;
            addLog.actual = temp.division(x, y);
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong division. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodMult(double x, double y)
        {
            addLog.expected = x * y;
            addLog.actual = temp.multiplication(x, y);
            addLog.LogThis();
            Assert.IsTrue(addLog.Comparison(), $"Error! Wrong multiplication. Expected: {addLog.expected} \u2260 {addLog.actual}");
        }
    }
}