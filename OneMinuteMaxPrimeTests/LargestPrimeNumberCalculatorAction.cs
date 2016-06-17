using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Compatibility;
using OneMinuteMaxPrime;

namespace OneMinuteMaxPrimeTests
{
    [TestFixture]
    public class LargestPrimeNumberCalculatorActionTests
    {
        [Test]
        public void CanRunForGivenAmountOfTime()
        {
            var timer = new Stopwatch();
            const int expectedExecuteionTime = 1;
            timer.Start();

            LargestPrimeNumberCalculatorAction.Execute(expectedExecuteionTime);
            timer.Stop();

            timer.Elapsed.Milliseconds.ShouldBeEquivalentTo(expectedExecuteionTime);
        }
    }
}