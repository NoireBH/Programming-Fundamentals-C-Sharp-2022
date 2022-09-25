using System;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokedCount = 0;
            int N50Percent = N / 2;
            while (N >= M)
            {
                N = Math.Abs(M - N);
                pokedCount++;
                if (N == N50Percent && Y != 0)
                {
                    if (N >= Y)
                    {
                        N = N / Y;
                    }
                    else
                    {
                        continue;
                    }
                    
                    
                }

            }
            Console.WriteLine(N);
            Console.WriteLine(pokedCount);
        }
    }
}
