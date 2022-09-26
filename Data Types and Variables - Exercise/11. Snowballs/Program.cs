using System;
using System.Numerics;
namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballCount = int.Parse(Console.ReadLine());
            BigInteger biggestValue = BigInteger.MinusOne;

            int maxSnowballSnow = 0;
            int maxSnowballTime = 0;
            int maxSnowballQuality = 0;

            for (int i = 0; i < snowballCount; i++)
            {
               int snowballSnow = int.Parse(Console.ReadLine());
               int  snowballTime = int.Parse(Console.ReadLine());
               int  snowballQuality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (value > biggestValue)
                {
                    biggestValue = value;
                    maxSnowballSnow = snowballSnow;
                    maxSnowballQuality = snowballQuality;
                    maxSnowballTime = snowballTime;

                }
            }
            Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {biggestValue} ({maxSnowballQuality})");
        }
    }
}
