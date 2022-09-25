using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalSpice = 0;
            int spiceExtracted = 0;
            
            while (true)
            {
                
                
                
                
                if (startingYield < 100)
                {
                    if (spiceExtracted  >= 26)
                    {
                        spiceExtracted -= 26;
                    }
                    break;
                }
               
                spiceExtracted += startingYield;
                totalSpice += spiceExtracted;
                startingYield -= 10;
                days++;
                if (spiceExtracted >= 26)
                {
                    spiceExtracted -= 26;
                }

            }

            Console.WriteLine(days);
            Console.WriteLine(spiceExtracted);
        }
    }
}
