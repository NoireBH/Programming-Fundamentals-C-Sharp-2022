using System;
using System.Linq;

namespace _02._Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string command;

            while (((command = Console.ReadLine()) != "end"))
            {
                string[] parts = command.Split(' ');
                

                if (parts[0] == "swap")
                {
                    int index1 = int.Parse(parts[1]);
                    int index2 = int.Parse(parts[2]);
                    int firstSwap = array[index1];
                    int secondSwap = array[index2];
                    array[index1] = secondSwap;
                    array[index2] = firstSwap;
                }
                else if (parts[0] == "multiply")
                {
                    int index1 = int.Parse(parts[1]);
                    int index2 = int.Parse(parts[2]);
                    array[index1] *= array[index2];
                }
                else if (parts[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }
                }
            }
            Console.WriteLine(String.Join(", ", array));
        }
    }
}
