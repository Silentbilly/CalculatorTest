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
        LoggerAssertion addLog = new LoggerAssertion();
        Calculator.Methods temp = new Calculator.Methods();
        [Test]
        [TestCaseSource(typeof(DataSource), "DataTest")]
        public void TestMethodAdd(double x, double y)
        {
            addLog.expected = x + y;
            addLog.actual = temp.addition(x, y);
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodDiff(double x, double y)
        {
            addLog.expected = x - y;
            addLog.actual = temp.difference(x, y);
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodDiv(double x, double y)
        {
            addLog.expected = x / y;
            addLog.actual = temp.division(x, y);
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(DataSource), "Datatest")]
        public void TestMethodMult(double x, double y)
        {
            addLog.expected = x * y;
            addLog.actual = temp.multiplication(x, y);
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorAdd(double x, double y)
        {
            addLog.expected = x + y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "+");
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorDiff(double x, double y)
        {
            addLog.expected = x - y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "-");
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorDiv(double x, double y)
        {
            addLog.expected = x / y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "/");
            addLog.logThis();
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorMult(double x, double y)
        {
            addLog.expected = x * y;
            addLog.actual = Calculator.Calculator.calculator(x, y, "*");
            addLog.logThis();
        }
    }
}