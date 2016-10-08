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
            //Напишете програма, която изчислява бонус точки на база резултат от игра. 
            //Потребителят трябва да въведе своите точки в интервалa[1; 9]. 
            //Ако точките са в интервала[1; 3], умножете ги по 5.
            //Ако точките са в интервала[4; 6], умножете ги по 10.
            //Ако точките са в интервала[7; 9], умножете ги по 50.
            //Резултатът изведете на екрана.
            Console.Write("Enter your score(between 1 and 9): ");
            int score = int.Parse(Console.ReadLine());
            int result = 0;

            if (score >= 1 && score <= 3)
            {
                result = score * 5;
            }
            else if (score >= 4 && score <= 6)
            {
                result = score * 10;
            }
            else if (score >= 7 && score <= 9)
            {
                result = score * 50;
            }
            else
            {
                Console.WriteLine("You have entered invalid score");
            }
            Console.WriteLine(result);



        }
    }
}
