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
            //Напишете програма, която отпечатва на конзолата числата от 1 до N, 
            //които не се делят на 3 или 7. Числото N се въвежда от конзолата.


            Console.Write("Enter some number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers from 1 to {0} that can't be devided by 3 AND 7:", a);
            for (int i = 1; i <= a; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Only the numbers from 1 to {0} that can't be devided by 3:", a);
            for (int i = 1; i <= a; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Only the numbers from 1 to {0} that can't be devided by 7:", a);
            for (int i = 1; i <= a; i++)
            {
                if (i % 7 != 0)
                {
                    Console.Write(" " + i);

                }

            }
            Console.WriteLine();
        }
    }
}
