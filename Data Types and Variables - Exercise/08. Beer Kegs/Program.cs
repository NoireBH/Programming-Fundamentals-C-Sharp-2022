using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double biggestNum = int.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestNum)
                {
                    biggestNum = volume;
                    biggestKeg = model; 
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
