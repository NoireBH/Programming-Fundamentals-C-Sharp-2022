using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightSaberSinglePrice = double.Parse(Console.ReadLine()); 
            double robeSinglePrice = double.Parse(Console.ReadLine());
            double beltSinglePrice = double.Parse(Console.ReadLine());
            int counter = 0;
            int beltCounterFree = 0;
            
            double student10Percent = studentCount + Math.Ceiling(studentCount * 0.1);

            for (int i = 1; i <= studentCount; i++)
            {
                counter++;
                if (counter % 6 == 0)
                {
                    beltCounterFree++;
                }
            }
            double totalMoneyNeeded = lightSaberSinglePrice * student10Percent + robeSinglePrice * (studentCount) + beltSinglePrice * (studentCount - beltCounterFree);
            if (money >= totalMoneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {(totalMoneyNeeded):f2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {Math.Abs(totalMoneyNeeded - money):f2}lv more.");
            }
        }
    }
}
