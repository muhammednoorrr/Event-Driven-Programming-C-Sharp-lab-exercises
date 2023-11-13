using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string skylineString = SkylineWriting(input);

            Console.WriteLine("Skyline Writing: " + skylineString);
            Console.ReadKey();
        }

        static string SkylineWriting(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i += 2)
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            return new string(charArray);

        }
    }
}
