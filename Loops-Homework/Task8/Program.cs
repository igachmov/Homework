using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        //public static int ForLoop(int result)
        //{
        //    int number = result;
        //    for (int i = 1; i < result; i++)
        //    {

        //        number = number * i;

        //    }

        //    return number;
        //}
        static void Main(string[] args)
        {
            //Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K. *
            //First Version
            //Console.Write("Enter N!: ");
            //int N = int.Parse(Console.ReadLine());
            //ForLoop(N);
            //Console.Write("Enter K!: ");
            //int K = int.Parse(Console.ReadLine());
            //ForLoop(K);
            //ForLoop(N - K);
            //Console.WriteLine("N!*K!/(N-K)!= " + (ForLoop(N) *ForLoop(K)/ForLoop(N-K)));

            //Second Version
            Console.Write("Enter N!: ");
            int N = int.Parse(Console.ReadLine());
            int result = N;

            for (int i = 1; i < N; i++)
            {
                result = result * i;
            }
            Console.WriteLine("N!= " + result);

            Console.Write("Enter K!: ");
            int K = int.Parse(Console.ReadLine());
            int result1 = K;

            for (int i = 1; i < K; i++)
            {
                result1 = result1 * i;
            }
            Console.WriteLine("K!= " + result1);

            int result2 = (N - K);
            for (int i = 1; i < (N - K); i++)
            {
                result2 = result2 * i;
            }
            Console.WriteLine("(N-K)!= " + result2);

            Console.WriteLine("N!*K!/(N-K)!= " + ((result * result1) / result2));


        }
    }
}
