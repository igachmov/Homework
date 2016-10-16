using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която обхожда предварително създаден
            //двумерен масив от числа и извежда на екрана само четните.
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());
            int[,] array1 = new int[rows,column];
            Random rand = new Random();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    int number = rand.Next(1, 101);
                    array1[i, j] = number;
                }
            }
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (array1[i, j] % 2 == 0)
                    {
                        Console.Write("|" + array1[i, j] + "|" + "\t");
                    }
                    else
                    {
                        Console.Write("| " + " |" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
