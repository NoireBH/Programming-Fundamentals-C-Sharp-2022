using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int currengSequence = 0;
            int longestSequence = 0;
            int sequenceNumber = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {

                int currentIndex = numbers[i];
                int nextIndex = numbers[i + 1];
                if (currentIndex == nextIndex)
                {
                    currengSequence++;

                }
                else
                {
                    currengSequence = 0;
                }
                if (currengSequence > longestSequence)
                {
                    longestSequence = currengSequence;
                    sequenceNumber = currentIndex;
                }



            }
            for (int k = 1; k <= longestSequence + 1; k++)
            {
                Console.Write(sequenceNumber + " ");
            }
        }
    }
}
