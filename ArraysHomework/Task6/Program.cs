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
            //Напишете програма, която обръща стойностите на един масив.
            Console.Write("Enter the lenght of the array: ");
            int number = int.Parse(Console.ReadLine());
            int[] array1 = new int[number];
            int[] array2 = new int[number];
            Console.Write("array1: ");
            for (int i = 0; i < number; i++)
            {
                array1[i] = i + 1;
                Console.Write(" {0}:{1}", i + 1, array1[i]);
            }
            Console.WriteLine();
            Console.Write("array2: ");
            for (int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[array1.Length - 1];
                array1[array1.Length - 1]--;
                Console.Write(" {0}:{1}", i + 1, array2[i]);
            }
            Console.WriteLine();
        }
    }
}
