using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            string text1 = Console.ReadLine();
            char symbol = text1[text1.Length - 1];
            Console.WriteLine("The last symbol is: " + symbol);

        }
    }
}
