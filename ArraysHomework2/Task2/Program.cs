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
            //Напишете програма, която позволява на потребителя да 
            //попълва масив с размери 3х4. Изведете масива на екрана.
            int[,] matrix = new int[3, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Enter element for {0}:{1} : ", i, j);
                    int number = int.Parse(Console.ReadLine());
                    matrix[i, j] = number;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("|" + matrix[i, j] + "|" + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}

