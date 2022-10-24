using System;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double studentAttendances = 0;
            double highestBonus = 0; //not double.min because we can receive 0 from the console.

            for (int i = 1; i <= students; i++)
            {
                double attendance = double.Parse(Console.ReadLine());                
                double totalBonus = (attendance / lectures) * (5 + bonus);
                if (totalBonus > highestBonus)
                {
                    highestBonus = totalBonus;
                    studentAttendances = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(highestBonus)}.");
            Console.WriteLine($"The student has attended {studentAttendances} lectures.");

        }
    }
}
