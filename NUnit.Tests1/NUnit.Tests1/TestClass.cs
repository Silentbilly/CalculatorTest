// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NLog;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TestMethodAdd(double x, double y)
        {
            Calculator.Methods temp = new Calculator.Methods();
            double expected = x + y;
            double actual = temp.addition(x, y);
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong addition. Expected: {expected} \u2260 {actual}");     
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TestMethodDiff(double x, double y)
        {
            Calculator.Methods temp = new Calculator.Methods();
            double expected = x - y;
            double actual = temp.difference(x, y);
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong addition. Expected: {x - y} \u2260 {actual}");
            

        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TestMethodDiv(double x, double y)
        {
            Calculator.Methods temp = new Calculator.Methods();
            double expected = x / y;
            double actual = temp.division(x, y);
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong division. Expected: {x / y} \u2260 {actual}");
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TestMethodMult(double x, double y)
        {
            Calculator.Methods temp = new Calculator.Methods();
            double expected = x * y;
            double actual = temp.multiplication(x, y);
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == temp.multiplication(x, y), $"Error! Wrong division. Expected: {x * y} \u2260 {actual}");
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorAdd(double x, double y)
        {
            double expected = x + y;
            double? actual = Calculator.Calculator.calculator(x, y, "+");
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong addition. Expected: {expected} \u2260 {actual}");
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorDiff(double x, double y)
        {
            double expected = x - y;
            double? actual = Calculator.Calculator.calculator(x, y, "-");
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong addition. Expected: {expected} \u2260 {actual}");
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorDiv(double x, double y)
        {
            double expected = x / y;
            double? actual = Calculator.Calculator.calculator(x, y, "/");
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong division. Expected: {expected} \u2260 {actual}");
        }

        [Test]
        [TestCaseSource(typeof(Data), "Datatest")]
        public void TesCalculatorMult(double x, double y)
        {
            double expected = x * y;
            double? actual = Calculator.Calculator.calculator(x, y, "*");
            Logger logger = LogManager.GetCurrentClassLogger();
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            Assert.IsTrue(expected == actual, $"Error! Wrong division. Expected: {expected} \u2260 {actual}");
        }
    }
}
