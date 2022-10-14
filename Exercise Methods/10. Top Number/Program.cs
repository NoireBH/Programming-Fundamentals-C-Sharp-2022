using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            int oddDigit = 0;
            int sum = 0;
            CheckForTopInteger(endValue, ref oddDigit, ref sum);
        }

        private static void CheckForTopInteger(int endValue, ref int oddDigit, ref int sum)
        {
            for (int i = 1; i <= endValue; i++)
            {
                int number = i;
                while (number > 0)
                {

                    int currentDigit = number % 10;
                    oddDigit = CheckForOddDigits(oddDigit, currentDigit);
                    sum += currentDigit;
                    number /= 10;
                }

                CheckIfSumIsDivisibleBy8(oddDigit, sum, i);
                sum = 0;
                oddDigit = 0;
            }
        }

        private static void CheckIfSumIsDivisibleBy8(int oddDigit, int sum, int i)
        {
            if ((sum) % 8 == 0 && oddDigit >= 1)
            {
                Console.WriteLine(i);

            }
        }

        private static int CheckForOddDigits(int oddDigit, int currentDigit)
        {
            if (currentDigit % 2 != 0)
            {
                oddDigit++;
            }

            return oddDigit;
        }

    }
}
