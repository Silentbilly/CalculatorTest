using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NLog;

namespace NUnit.Tests1
{
    class LoggerClass
    {
        public double expected;
        public double? actual;
        public bool Comparison()
        {
            return expected == actual;
        }
        Logger logger = LogManager.GetCurrentClassLogger();
        public void LogThis()
        {
            logger.Trace($"Expected: {expected}, Actual: {actual}, {expected == actual}");
            if (!Comparison())
            {
                logger.Error($"Error! {expected} IS NOT EQUAL {actual}");
            }
        }
    }
}
