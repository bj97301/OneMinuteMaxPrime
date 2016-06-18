using System;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Compatibility;
using OneMinuteMaxPrime;

namespace OneMinuteMaxPrimeTests
{
    [TestFixture]
    public class LargestPrimeNumberCalculatorActionTests
    {
        [TestCase(1)]
        [TestCase(50)]
        [TestCase(90)]
        public void RunsForGivenAmountOfTime(int expectedExecuteionTime)
        {
            var timer = new Stopwatch();
            timer.Start();

            LargestPrimeNumberCalculatorAction.Execute(expectedExecuteionTime);
            timer.Stop();

            timer.Elapsed.Milliseconds.Should().BeInRange(expectedExecuteionTime - 10, expectedExecuteionTime + 10);
        }

        [Test]
        public void CalculatesALargerPrimeNumberForAGivenPeriodOfTime()
        {
            var result = LargestPrimeNumberCalculatorAction.Execute(10);

            result.Should().BeGreaterThan(2);
        }

        [Test]
        public void IndicatesElapseTimeAndCurrentMaxPrimeNumber()
        {
            string message = null;
            Action<string> displayLogger = x => { message = x; };
            LargestPrimeNumberCalculatorAction.Execute(0, displayLogger);

            message.Should().Contain("second", "should display the timer progress");
            message.Should().Contain("prime", "should display the highest numbers calculated along the way");
        }
    }
}