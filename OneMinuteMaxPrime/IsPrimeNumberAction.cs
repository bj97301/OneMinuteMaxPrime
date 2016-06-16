using System;

namespace OneMinuteMaxPrime
{
    public class IsPrimeNumberAction
    {
        public static bool Execute(int number)
        {
            if (number == 1)
            {
                return false;
            }

            var boundary = (int) Math.Floor(Math.Sqrt(number));

            for (var i = 2; i <= boundary; ++i)
            {
                if (number%i == 0) return false;
            }

            return true;
        }
    }
}