using System;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace NCalc.Tests
{
    [TestFixture]
    public class PerformanceTests
    {
        public static void AssertTime(Action action, TimeSpan expected, int times = 100)
        {
            // warmup
            action();

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < times; i += 1) action();
            stopwatch.Stop();
            Console.Write(stopwatch.Elapsed);
            Assert.IsTrue(stopwatch.Elapsed <= expected);
        }

        [Test]
        public void ExpressionMixNoCachePerformanceTest()
        {
            var expressions = new[]
            {
                "Abs(-1) + Cos(2)",
                "2 + 3 + 5",
                "2 * 3 + 5",
                "2 * (3 + 5)",
                "2 * (2*(2*(2+1)))",
                "10 % 3",
                "true or false",
                "not true",
                "false || not (false and true)",
                "3 > 2 and 1 <= (3-2)",
                "3 % 2 != 10 % 3"
            };

            AssertTime(() => expressions.ToList().ForEach(e => new Expression(e, EvaluateOptions.NoCache).Evaluate()), TimeSpan.FromMilliseconds(500));
        }
    }
}