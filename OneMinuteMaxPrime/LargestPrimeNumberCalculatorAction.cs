using System;
using System.Diagnostics;

namespace OneMinuteMaxPrime
{
    public class LargestPrimeNumberCalculatorAction
    {
        public static int Execute(int milliseconds, Action<string> displayLogger = null)
        {
            if (displayLogger == null)
            {
                displayLogger = Console.Write;
            }

            var currentLargestPrimeNumber = 3;
            var count = currentLargestPrimeNumber;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            while (stopwatch.Elapsed < TimeSpan.FromMilliseconds(milliseconds))
            {
                if (stopwatch.Elapsed.Milliseconds%100 == 0)
                {
                    WriteToConsole(displayLogger, stopwatch, currentLargestPrimeNumber);
                }
                count++;
                if (IsPrimeNumberAction.Execute(count))
                {
                    currentLargestPrimeNumber = count;
                }
            }
            WriteToConsole(displayLogger, stopwatch, currentLargestPrimeNumber);
            stopwatch.Stop();
            return currentLargestPrimeNumber;
        }

        private static void WriteToConsole(Action<string> displayLogger, Stopwatch stopwatch, int currentLargestPrimeNumber)
        {
            var logMessage =
                $"\r{stopwatch.Elapsed.Seconds} seconds, current max prime number: {currentLargestPrimeNumber}";
            displayLogger(logMessage);
        }
    }
}