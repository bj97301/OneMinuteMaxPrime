using System;
using System.Diagnostics;

namespace OneMinuteMaxPrime
{
    public class LargestPrimeNumberCalculatorAction
    {
        public static int Execute(int milliseconds)
        {
            var currentLargestPrimeNumber = 3;
            var s = new Stopwatch();
            s.Start();
            while (s.Elapsed <= TimeSpan.FromMilliseconds(milliseconds))
            {
            }
            s.Stop();

            return currentLargestPrimeNumber;
        }
    }
}