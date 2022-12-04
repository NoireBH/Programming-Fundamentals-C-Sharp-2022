using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                string pattern = @"^(\$|\%)(?<tag>[A-Z][a-z]{3,})\1: \[(?<firstNum>\d+)\]\|\[(?<secondNum>\d+)\]\|\[(?<thirdNum>\d+)\]\|$";
                Regex regex = new Regex(pattern);

                MatchCollection matches = regex.Matches(message);

                if (matches.Count == 0)
                {
                    Console.WriteLine("Valid message not found!");

                }

                foreach (Match text in matches)
                {
                    int firstNum = int.Parse(text.Groups["firstNum"].Value);
                    int secondNum = int.Parse(text.Groups["secondNum"].Value);
                    int thirdNum = int.Parse(text.Groups["thirdNum"].Value);
                    string tag = text.Groups["tag"].Value;
                    char symbolOfFirstNum = (char)firstNum;
                    char symbolOfSecondNum = (char)secondNum;
                    char symbolOfThirdNum = (char)thirdNum;
                    StringBuilder decryptedMessage = new StringBuilder();
                    decryptedMessage.Append(symbolOfFirstNum);
                    decryptedMessage.Append(symbolOfSecondNum);
                    decryptedMessage.Append(symbolOfThirdNum);

                    Console.WriteLine($"{tag}: {decryptedMessage}");

                }

            }




        }
    }
}
