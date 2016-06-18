using System;

namespace OneMinuteMaxPrime
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input the number of seconds the program will run then press enter/return.");
            var seconds = Convert.ToInt32(Console.ReadLine());

            LargestPrimeNumberCalculatorAction.Execute((int) TimeSpan.FromSeconds(seconds).TotalMilliseconds,
                Console.Write);
            Console.ReadLine();
        }
    }
}