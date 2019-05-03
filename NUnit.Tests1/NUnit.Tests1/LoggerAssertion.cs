using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NLog;

namespace NUnit.Tests1
{
    class LoggerAssertion
    {
        public double expected;
        public double? actual;
        Logger logger = LogManager.GetCurrentClassLogger();
        public void testAndLogThis()
        {
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            if (expected != actual)
            {
                logger.Error($"Error! {expected} \u2260 {actual}");
            }
            Assert.IsTrue(expected == actual, $"Error! Wrong addition. Expected: {expected} \u2260 {actual}");
        }
    }
}
