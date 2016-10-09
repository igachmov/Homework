using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Направете програма, която извежда на конзолата всички числа от 1 до 100, 
            //които се делят или на 7, или на 11, без остатък. 
            //Решете задачата по 3 различни начина: с трите цикли от лекцията

            //First version

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i%7==0)
            //    {
            //        Console.Write("The number can be devided by 7:  ");

            //        if (i % 7 == 0 && i % 11 == 0)
            //        {
            //            Console.Write("and 11: ");

            //        }
            //        Console.WriteLine(i);
            //    }
            //    else if (i % 11 == 0)
            //    {
            //        Console.Write("The number can be devided by 11: ");
            //        Console.WriteLine(i);
            //    }

            //}

            //Second version

            //int a = 0;
            //while (a != 100)
            //{
            //    a++;
            //    if (a % 7 == 0)
            //    {
            //        Console.Write("The number can be devided by 7:  ");

            //        if (a % 7 == 0 && a % 11 == 0)
            //        {
            //            Console.Write("and 11: ");

            //        }
            //        Console.WriteLine(a);
            //    }
            //    else if (a % 11 == 0)
            //    {
            //        Console.Write("The number can be devided by 11: ");
            //        Console.WriteLine(a);
            //    }

            //}

            //Third version
            int a = 0;
            do
            {
                a++;
                if (a % 7 == 0)
                {
                    Console.Write("The number can be devided by 7:  ");

                    if (a % 7 == 0 && a % 11 == 0)
                    {
                        Console.Write("and 11: ");

                    }
                    Console.WriteLine(a);
                }
                else if (a % 11 == 0)
                {
                    Console.Write("The number can be devided by 11: ");
                    Console.WriteLine(a);
                }

            } while (a != 100);
        }
    }
}
