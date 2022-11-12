using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int explosionStrength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (explosionStrength > 0 && text[i] != '>')
                {
                    text = text.Remove(i, 1);
                    explosionStrength--;
                    i--;
                }
                else if (text[i] == '>')
                {
                    explosionStrength += int.Parse(text[i + 1].ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
