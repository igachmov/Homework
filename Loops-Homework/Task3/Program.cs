using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която чете от конзолата поредица от цели числа(примерно 5 числа)
            // и отпечатва най - малкото и най-голямото от тях.

            Console.WriteLine("Enter 5 numbers:");
            Console.Write("First number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Second number: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Third number: ");
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Fourth number: ");
            int fourth = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Fifth number: ");
            int fifth = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] a = { first, second, third, fourth, fifth };
            int small = a[0];
            int large = a[4];
            for (int i = 0; i < a.Length; i++)
            {
                if (small > a[i])
                {
                    int temp = small;
                    small = a[i];
                    a[i] = small;
                }
                if (large < a[i])
                {
                    int temp = large;
                    large = a[i];
                    a[i] = large;
                }
            }

            Console.WriteLine("The smallest number is: " + small);
            Console.WriteLine("The largest number is: " + large);

        }
    }
}
