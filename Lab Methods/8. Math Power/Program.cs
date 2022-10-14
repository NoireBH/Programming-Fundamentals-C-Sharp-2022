using System;

namespace _8._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double mathPower = MathPower(number, power);
            Console.WriteLine(mathPower);
        }

         static double MathPower(double number, double power)
        {
            
            double mathPower = Math.Pow(number, power);
            return mathPower;
        }
    }
}
