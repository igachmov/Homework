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
            Console.Write("Enter the side of the triangle: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the height of the triangle: ");
            int h = int.Parse(Console.ReadLine());
            int area = (a*h)/2;
            Console.WriteLine("The area of the triangle is " + area);

        }
    }
}
