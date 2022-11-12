using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string text = Console.ReadLine();
            var encryptedText = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {   int currentChar = text[i] + 3;
                encryptedText.Append((char)currentChar);
            }

            Console.Write(encryptedText);
        }
    }
}
