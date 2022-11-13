using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 1. receive key and string until "find".  2. loop through every string and reduce ascii value with corresponding num.
            // 2.5 if length of key is less than string start from the beginning of the key.
            int[] keys = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string input;
            
            while ((input = Console.ReadLine()) != "find")
            {
                var decryptedText = new StringBuilder();
                int firstIndexOfType = 0;
                int lastIndexOfType = 0;
                int firstIndexOfCoordinates = 0;
                int lastIndexOfCoordinates = 0;
                var decryptedType = new StringBuilder();
                var decryptedCoordinates = new StringBuilder();
                string encryptedText = input;
                int countOfInputs = 0;
                for (int i = 0; i < encryptedText.Length; i++)
                {
                   
                    if (countOfInputs >= encryptedText.Length)
                    {
                        break;
                    }

                    int currentChar = encryptedText[countOfInputs] - keys[i];                
                    decryptedText.Append((char)currentChar);
                    countOfInputs++;

                    if (i == keys.Length - 1)
                    {
                        i = -1;
                    }
                }
                firstIndexOfType = decryptedText.ToString().IndexOf('&');
                lastIndexOfType = decryptedText.ToString().LastIndexOf('&');
                firstIndexOfCoordinates = decryptedText.ToString().IndexOf('<');
                lastIndexOfCoordinates = decryptedText.ToString().LastIndexOf('>');

                for (int i = firstIndexOfType + 1; i < lastIndexOfType; i++)
                {
                   decryptedType.Append((char)decryptedText[i]);
                }

                for (int i = firstIndexOfCoordinates + 1; i < lastIndexOfCoordinates; i++)
                {
                    decryptedCoordinates.Append((char)decryptedText[i]);
                }

                Console.WriteLine($"Found {decryptedType} at {decryptedCoordinates}");
            }


        }
    }
}
