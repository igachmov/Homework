using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N се въвежда от конзолата.

            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
