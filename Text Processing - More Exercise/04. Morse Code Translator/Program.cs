using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var morseCodeIntoLetters = new Dictionary<char, string>
            {
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...- "},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."},
                {' ', "|"}
            };

            string[] morseCode = Console.ReadLine().Split();
            var decodedCode = new StringBuilder();

            foreach (string code in morseCode)
            {
                decodedCode.Append(morseCodeIntoLetters.FirstOrDefault(k => k.Value == code).Key);
            }
                
            Console.WriteLine(decodedCode);
        }
    }
}
