using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string input = Console.ReadLine();
            int mathAbs = Math.Abs(int.Parse(input));
            int number = Math.Abs(int.Parse(input));
            
            int sumOfEvenDigits = GetSumOfEvenDigits(mathAbs.ToString());
            int sumOfOddDigits = GetSumOfOddDigits(mathAbs.ToString());
            
            int result = sumOfEvenDigits * sumOfOddDigits;
            Console.WriteLine(result);



        }
       
       private static int GetSumOfEvenDigits(string input)
        {   
            int sumEven = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = (int.Parse(input[i].ToString()));
                if (currentNum % 2 ==0)
                {
                    sumEven += currentNum;
                }
            }
            return sumEven;

        }
       private static int GetSumOfOddDigits(string input)
        {
            int sumOdd = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = (int.Parse(input[i].ToString()));
                if (currentNum % 2 != 0)
                {
                    sumOdd += currentNum;
                }
            }
            return sumOdd;
        }
    }
}
