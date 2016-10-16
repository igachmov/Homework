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
            //* Напишете програма, която попълва квадратна матрица спираловидно по посока на часовниковата страна. 
            // Потребителят въвежда размерност на матрицата.
            Console.Write("Enter number for row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter number for column: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];
            int checkRow = 0;
            int checkColumn = 0;
            string direction = "right";
            for (int i= 1; i <=matrix.Length; i++)
            {
                if (direction == "right" && (checkColumn > column-1 || matrix[checkRow, checkColumn] !=0))
                {
                    direction = "down";
                    checkColumn--;
                    checkRow++;
                }
                else if(direction == "down" && (checkRow > row - 1 || matrix[checkRow, checkColumn] != 0))
                {
                    direction = "left";
                    checkRow--;
                    checkColumn--;
                }
                else if (direction == "left" && (checkColumn <0 || matrix[checkRow, checkColumn] != 0))
                {
                    direction = "up";
                    checkColumn++;
                    checkRow--;
                    
                }
                else if (direction == "up" && (checkRow <0 || matrix[checkRow, checkColumn] != 0))
                {
                    direction = "right";
                    checkRow++;
                    checkColumn++;
                }
                matrix[checkRow, checkColumn] = i;

                if (direction == "right")
                {
                    checkColumn++;
                }
                if (direction == "down")
                {
                    checkRow++;
                }
                if (direction == "left")
                {
                    checkColumn--;
                }
                if (direction == "up")
                {
                    checkRow--;
                }
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("|" + matrix[r, c] + "|" + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
