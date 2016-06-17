using System;
using System.Diagnostics;

namespace OneMinuteMaxPrime
{
    public class LargestPrimeNumberCalculatorAction
    {
        public static int Execute(int milliseconds)
        {
            var currentLargestPrimeNumber = 3;
            var count = currentLargestPrimeNumber;
            var s = new Stopwatch();
            s.Start();
            while (s.Elapsed <= TimeSpan.FromMilliseconds(milliseconds))
            {
                count++;
                if (IsPrimeNumberAction.Execute(count))
                {
                    currentLargestPrimeNumber = count;
                }
            }
            s.Stop();

            return currentLargestPrimeNumber;
        }
    }
}