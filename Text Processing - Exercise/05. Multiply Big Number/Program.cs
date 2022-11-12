using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            var multipliedNum = new StringBuilder();

            int remainder = 0;

            if (firstNum == "0" || secondNum == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(firstNum[i].ToString());
                int product = currentDigit * int.Parse(secondNum) + remainder;
                int result = product % 10;
                remainder = product / 10;
                multipliedNum.Insert(0, result);
            }

            if (remainder > 0 )
            {
                multipliedNum.Insert(0, remainder);
            }

            Console.WriteLine(multipliedNum);

        }
    }
}
