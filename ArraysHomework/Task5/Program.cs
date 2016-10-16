using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Прекопирайте един масив от цели числа в друг масив.
            Console.Write("Enter the lenght of the array: ");
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int[] array2 = new int[N];
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter a number: ");
                int x = int.Parse(Console.ReadLine());
                array1[i] = x;
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("The numbers in first array: {0}:{1}", i + 1, array1[i]);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = array1[i];               
                Console.WriteLine("The numbers in second array: {0}:{1}",i+1,array2[i]);
            }


        }
    }
}
