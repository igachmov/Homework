using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която проверява дали един масив е симетричен.

            int[] array1 = new int[5] { 1, 2, 3, 2, 1,};
            for (int i = 0; i < array1.Length; i++)
            {
                if(array1[i] == array1[array1.Length - (i+1)])
                {
                    Console.WriteLine("Correct!");
                    Console.Write("{0}={1}",array1[i], array1[array1.Length- (i+1)]);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The array isn't symmetric");
                    break;
                }
            }
        }
    }
}
