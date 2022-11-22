using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            int n = int.Parse(Console.ReadLine());
            string numbers = string.Empty;
            string pattern = @"@#{1,}(?<barcode>[A-Z][A-Z-a-z\d]+[A-Z])@#{1,}";
            string numPattern = @"\d";
            Regex regex = new Regex(pattern);
            Regex regexForNumbers = new Regex(numPattern);
            
            for (int i = 0; i < n; i++)
            {
                string currentBarCode = Console.ReadLine();
                Match match = regex.Match(currentBarCode);
                string barcode = match.Groups["barcode"].Value;

                if (barcode.Length < 6)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                
                if (match.Success)
                {
                    MatchCollection matches = regexForNumbers.Matches(currentBarCode);
                    if (matches.Count == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    string productGroup = String.Empty;

                    foreach (Match number in matches)
                    {
                        productGroup += number.ToString();
                    }

                    if (matches.Count > 0)
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                  
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }



        }
    }
}
