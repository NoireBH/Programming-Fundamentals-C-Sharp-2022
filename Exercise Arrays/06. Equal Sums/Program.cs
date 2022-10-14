﻿using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += array[k];
                }
              
                for (int j = array.Length - 1; j > i; j--)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}