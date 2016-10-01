using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Option 1
            string hello = "Hello";
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine(hello == text);

            //Option 2
            if(text == hello)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


        }
    }
}
