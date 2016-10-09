using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Напишете програма която пресмята с колко 0ли завършва факториелът на дадено число.



            Console.Write("Enter number: ");
            int a = int.Parse(Console.ReadLine());
            long b = 1;
            int c = 0;

            while (a > 0)
            {
                b *= a--;
            }
            Console.WriteLine("The factorial is: " + b);

            while (b % 10 == 0)
            {
                b = b / 10;
                c++;
            }
            Console.WriteLine("The number has " + c + " zero/es");
        }
    }
}

