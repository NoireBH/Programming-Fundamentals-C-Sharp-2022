using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotationsNeeded = int.Parse(Console.ReadLine());
            int timesToRotate = rotationsNeeded % array.Length;
            
            for (int i = 0; i < timesToRotate; i++)
            {
                int firstelement = array[0];
                for (int j = 1; j < array.Length; j++)
                {

                    array[j - 1] = array[j];                   
                }
                array[array.Length - 1] = firstelement;

            }
            
            Console.WriteLine(String.Join(" ", array));
        }


    }
}
