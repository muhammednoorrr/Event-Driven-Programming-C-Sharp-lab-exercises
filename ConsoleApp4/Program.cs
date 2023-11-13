using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a String");
            String stri= Console.ReadLine();

            int Leng = stri.Length;
            String newstr="";
            for(int i = Leng - 1; i >=0; i--) {
                newstr += stri[i];
            }
           Console.WriteLine(newstr);
            Console.ReadKey();

        }
    }
}
