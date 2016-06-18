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
        [TestCase(5)]
        [TestCase(90)]
        public void CanRunForGivenAmountOfTime(int expectedExecuteionTime)
        {
            var timer = new Stopwatch();
            timer.Start();

            LargestPrimeNumberCalculatorAction.Execute(expectedExecuteionTime);
            timer.Stop();

            timer.Elapsed.Milliseconds.ShouldBeEquivalentTo(expectedExecuteionTime);
        }

        [Test]
        public void CalculatesALargerPrimeNumberForAGivenPeriodOfTime()
        {
            var result = LargestPrimeNumberCalculatorAction.Execute(10);

            result.Should().BeGreaterThan(3);
            IsPrimeNumberAction.Execute(result).Should().BeTrue();
        }

        [Test]
        public void ShouldIndicateElapseTimeAndCurrentMaxPrimeNumber()
        {
            string message = null;
            Action<string> write = x => { message = x; };
            LargestPrimeNumberCalculatorAction.Execute(0, write);

            message.Should().Contain("second", "should display the timer progress");
            message.Should().Contain("prime", "should display the highest numbers calculated along the way");
        }
    }
}