using FluentAssertions;
using NUnit.Framework;
using OneMinuteMaxPrime;

namespace OneMinuteMaxPrimeTests
{
    [TestFixture]
    internal class IsPrimeNumberTests
    {
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        public void CanRecognizeKnownPrimeNumbers(int number)
        {
            IsPrimeNumberAction.Execute(number).Should().BeTrue();
        }

        [TestCase(1)]
        [TestCase(4)]
        [TestCase(9)]
        public void CanRecognizeKnownNotPrimeNumbers(int number)
        {
            IsPrimeNumberAction.Execute(number).Should().BeFalse();
        }
    }
}