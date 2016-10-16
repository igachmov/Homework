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
            //Напишете програма, която търси число в масив от числа и връща индекса на първото намерено число.
            Console.Write("Enter the lenght of the arrya: ");
            int N = int.Parse(Console.ReadLine());

            int[] number = new int[N];
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write("Enter some number for position {0}: ",i+1);
                int x = int.Parse(Console.ReadLine());
                number[i] = x;
            }
            Console.WriteLine("Enter the number you are searching for: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < number.Length; i++)
            {
                if (a == number[i])
                {
                    Console.WriteLine("The first position of number {0} is {1}", number[i], i + 1);
                    break;
                }
                
                
            }
           
        }
    }
}
