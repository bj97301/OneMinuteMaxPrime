using System;
using System.Diagnostics;

namespace OneMinuteMaxPrime
{
    public class LargestPrimeNumberCalculatorAction
    {
        public static int Execute(int milliseconds, Action<string> displayLogger = null)
        {
            var currentLargestPrimeNumber = 2;
            var count = currentLargestPrimeNumber;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            while (stopwatch.Elapsed < TimeSpan.FromMilliseconds(milliseconds))
            {
                count++;
                var shouldLog = stopwatch.Elapsed.Milliseconds%100 == 0;
                if (shouldLog)
                {
                    UpdateDisplay(displayLogger,
                        currentLargestPrimeNumber,
                        stopwatch.Elapsed.Seconds);
                }
                if (IsPrimeNumberAction.Execute(count))
                {
                    currentLargestPrimeNumber = count;
                }
            }

            UpdateDisplay(displayLogger,
                currentLargestPrimeNumber,
                TimeSpan.FromMilliseconds( milliseconds).TotalSeconds);

            stopwatch.Stop();
            return currentLargestPrimeNumber;
        }

        private static void UpdateDisplay(Action<string> displayLogger, int currentLargestPrimeNumber,
            double totalSeconds)
        {
            displayLogger?.Invoke(
                $"\r{totalSeconds} seconds, current max prime number: {currentLargestPrimeNumber}");
        }
    }
}