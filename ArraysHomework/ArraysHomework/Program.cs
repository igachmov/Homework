using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която намира сбора на всичките четни елементи в масив.

            int N = int.Parse(Console.ReadLine());
            int[] number = new int[N];
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }            
            for (int i = 0; i < N; i++)
            {
                if (number[i] % 2 == 0)
                {
                    sum = sum + number[i];
                }
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
