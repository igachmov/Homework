using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        //Напишете програма, която пресмята N!/ K!за дадени N и K (1 < K < N). *

        public static int ForLoop(int result)
        {
            int number = result;
            for (int i = 1; i < result; i++)
            {

                number = number * i;

            }
            Console.WriteLine(number);
            return number;
        }
        static void Main(string[] args)
        {
           

            //First Version
            Console.Write("Enter N!: ");
            int N = int.Parse(Console.ReadLine());
            
            ForLoop(N);
            Console.Write("Enter K!: ");
            int K = int.Parse(Console.ReadLine());
            ForLoop(K);
            if (N > K && N > 1 && K > 1)
            {
                Console.WriteLine("N!/K!= " + (ForLoop(N) / ForLoop(K)));
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            //Second Version

            //Console.Write("Enter N!: ");
            //int N = int.Parse(Console.ReadLine());
            //int result = N;

            //for (int i = 1; i < N; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine(result);

            //Console.Write("Enter K!: ");
            //int K = int.Parse(Console.ReadLine());
            //int result1 = K;

            //for (int i = 1; i < K; i++)
            //{
            //    result1 = result1 * i;
            //}
            //Console.WriteLine(result1);

            //   if (N > K && N > 1 && K > 1)
            //{
            //    Console.WriteLine("N!/K!= " + (ForLoop(N) / ForLoop(K)));
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}



        }
    }
}
