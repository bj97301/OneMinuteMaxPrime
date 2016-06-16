using FluentAssertions;
using NUnit.Framework;
using OneMinuteMaxPrime;

namespace OneMinuteMaxPrimeTests
{
    [TestFixture]
    internal class IsPrimeNumberTests
    {
        [TestCase(5)]
        [TestCase(3)]
        public void CanRecognizeKnownPrimeNumbers(int number)
        {
            IsPrimeNumberAction.Execute(number).Should().BeTrue();
        }
    }
}