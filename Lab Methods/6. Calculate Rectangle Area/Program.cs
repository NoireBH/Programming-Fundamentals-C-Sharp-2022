using System;

namespace _6._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a  = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double area = GetRectangleArea(a, b);
            Console.WriteLine(area);

            static double GetRectangleArea(double a, double b)
            {
                return a * b;
            }
        }
    }
}
