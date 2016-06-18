using System;
using System.Diagnostics;

namespace OneMinuteMaxPrime
{
    public class LargestPrimeNumberCalculatorAction
    {
        public static int Execute(int milliseconds, Action<string> displayLogger = null)
        {
            var currentLargestPrimeNumber = 3;
            var count = currentLargestPrimeNumber;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed < TimeSpan.FromMilliseconds(milliseconds))
            {
                if (stopwatch.Elapsed.Milliseconds%100 == 0)
                {
                    displayLogger?.Invoke(
                        $"\r{stopwatch.Elapsed.Seconds} seconds, current max prime number: {currentLargestPrimeNumber}");
                }
                count++;
                if (IsPrimeNumberAction.Execute(count))
                {
                    currentLargestPrimeNumber = count;
                }
            }
            displayLogger?.Invoke(
                $"\r{stopwatch.Elapsed.Seconds} seconds, current max prime number: {currentLargestPrimeNumber}");
            stopwatch.Stop();
            return currentLargestPrimeNumber;
        }
    }
}