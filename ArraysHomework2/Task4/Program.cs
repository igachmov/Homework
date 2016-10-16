using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която принтира на екрана числата от 30 до 1 в обратен ред,
            //подредени в 5 реда и 6 колони. Да се реши с двумерен масив.
            int[,] array1 = new int[5, 6];
            int number = 31;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    number--;
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
