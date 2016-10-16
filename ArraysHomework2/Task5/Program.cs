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
            //*Напишете програма, която попълва квадратна матрица: първо вертикално, 
            //след това хоризонтално. Потребителят въвежда размерност на матрицата.
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());
            int[,] array1 = new int[rows, column];


            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    int number = i + 1;
                    array1[j, i] = number;
                }

            }

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write("|" + array1[i, j] + "|" + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    int number = i + 1;
                    array1[i, j] = number;
                }

            }

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.Write("|" + array1[i, j] + "|" + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
