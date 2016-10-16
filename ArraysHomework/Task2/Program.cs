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
            //Напишете програма, която попълва числата на Фибоначи в масив. Потребител въвежда колко да е голям масива.
            int N = int.Parse(Console.ReadLine());
            int[] Fibonacci = new int[N];
            int a = 0;
            int b = 1;
            for (int i = 0; i < N; i++)
            {
                int temp = a;                
                a = b;               
                b = a + b;
                Fibonacci[i] = a;
                Console.WriteLine("{0}:{1}",i+1,Fibonacci[i]);
            }
           
            
        }
    }
}
