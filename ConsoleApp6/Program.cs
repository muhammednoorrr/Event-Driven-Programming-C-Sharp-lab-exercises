using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int digitCount = 0;
            int alphabetCount = 0;
            int specialCharCount = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine($"Digits: {digitCount}");
            Console.WriteLine($"Alphabets: {alphabetCount}");
            Console.WriteLine($"Special Characters: {specialCharCount}");
        }
    }
}
