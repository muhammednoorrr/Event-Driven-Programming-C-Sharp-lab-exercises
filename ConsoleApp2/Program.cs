using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();
            

            int length = CalculateStringLength(userInput);

            Console.WriteLine($"Length of the string: {length}");
            Console.ReadKey();
        }
        static int CalculateStringLength(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                count++;
            }

            return count;
        }
        }
}
