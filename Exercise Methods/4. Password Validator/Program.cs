using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int characterLenght = CheckCharacterLenght(password);
            bool allisTrue = true;

            if (characterLenght < 6 || characterLenght > 10)
            {
                allisTrue = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            bool isLettersAndNumbers = CheckIfItContainsOnlyLettersAndDigits(password);

            if (!isLettersAndNumbers)
            {
                allisTrue = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            int digitCount = CheckIfOnlyTwoDigits(password);

            if (digitCount < 2)
            {
                allisTrue = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (allisTrue)
            {
                Console.WriteLine("Password is valid");
            }

        }
        static int CheckCharacterLenght(string password)
        {
            int characterNum = 0;

            for (int i = 0; i < password.Length; i++)
            {
                characterNum++;
            }
            return characterNum;

        }
        static bool CheckIfItContainsOnlyLettersAndDigits(string password)
        {
            bool result = password.All(Char.IsLetterOrDigit);
            return result;

        }

        static int CheckIfOnlyTwoDigits(string password)
        {
            int digitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    digitCount++;
                }
            }

            return digitCount;
        }


    }
}


