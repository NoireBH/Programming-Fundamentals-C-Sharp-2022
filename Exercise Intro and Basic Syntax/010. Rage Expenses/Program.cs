using System;

namespace _010._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int count = 0;
            int keyboardCount = 0;
            double expenses = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                count++;
                if (count % 2 == 0 && count % 3 == 0)
                {   
                    expenses += keyboardPrice + headsetPrice + mousePrice;
                    keyboardCount++;
                    if (keyboardCount % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                    
                }
                else if (count % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                else if (count % 3 == 0)
                {
                    expenses += mousePrice;
                }
               
            }
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
