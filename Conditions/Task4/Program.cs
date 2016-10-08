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
            //Решете задачата от клас използвайки Switch конструкция.
            Console.Write("Enter your number: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("!!!!!!!!!!!!!MENU!!!!!!!!!!!!!");
            Console.WriteLine("When the number is between 1 and 5 and you type \"1\" you will see if the number is even or odd ");
            Console.WriteLine("When the number is between 6 and 15 and you type \"2\" you will see if the number can be devided by 3 without remainder ");
            Console.WriteLine("When  you type \"3\" you will see if the number is 0, positive or negative ");
            Console.WriteLine();
            
            string condition = null;
            while (condition != "exit")
            {

                Console.Write("Enter number bettween 1 and 3 (see the menu): ");

                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        if (num >= 1 && num <= 5)
                        {
                            if (num % 2 == 0)
                            {
                                Console.WriteLine("The number is even");
                            }
                            else
                            {
                                Console.WriteLine("The number is odd");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Try some other condition");
                        }

                        break;

                    case "2":

                        if (num >= 6 && num <= 15)
                        {
                            if (num % 3 == 0)
                            {
                                Console.WriteLine("The number can be devided by 3 without remainder ");
                            }
                            else
                            {
                                Console.WriteLine("The number can't be devided by 3 without remainder ");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Try some other condition");
                        }


                        break;

                    case "3":

                        if (num == 0)
                        {
                            Console.WriteLine("The number is 0");
                            Console.WriteLine("Try some other condition");
                        }
                        else if (num > 0)
                        {
                            Console.WriteLine("The number is positive");
                            Console.WriteLine("Try some other condition");
                        }
                        else if (num < 0)
                        {
                            Console.WriteLine("The number is negative");
                            Console.WriteLine("Try some other condition");
                        }
                        break;

                    case "exit":
                        return;

                    default:
                        Console.WriteLine("ERRROR");
                        break;


                }
                Console.Write("Press ENTER to continue or type \"exit\": ");
                string conditions = Console.ReadLine();
                condition = conditions;
            }

        }
    }
}
