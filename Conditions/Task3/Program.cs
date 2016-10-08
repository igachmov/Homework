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
            //Класическото тесте карти се състои от 13 различни вида карти съответно 
            //2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.Направете програма, 
            //която приема от конзолата карта и принтира "Валидна карта", 
            //ако въведената карта представлява валидна карта, 
            //и съответно принтира "Невалидна карта", ако е невалидна карта. 

            //**First version**

            Console.Write("Enter card(2,3,4,5,6,7,8,9,10,J,Q,K,A): ");
            string card = Console.ReadLine();
            switch (card)
            {
                case "2":
                    Console.WriteLine("Valid card");
                    break;
                case "3":
                    Console.WriteLine("Valid card");
                    break;
                case "4":
                    Console.WriteLine("Valid card");
                    break;
                case "5":
                    Console.WriteLine("Valid card");
                    break;
                case "6":
                    Console.WriteLine("Valid card");
                    break;
                case "7":
                    Console.WriteLine("Valid card");
                    break;
                case "8":
                    Console.WriteLine("Valid card");
                    break;
                case "9":
                    Console.WriteLine("Valid card");
                    break;
                case "10":
                    Console.WriteLine("Valid card");
                    break;
                case "J":
                    Console.WriteLine("Valid card");
                    break;
                case "Q":
                    Console.WriteLine("Valid card");
                    break;
                case "K":
                    Console.WriteLine("Valid card");
                    break;
                case "A":
                    Console.WriteLine("Valid card");
                    break;
                default:
                    Console.WriteLine("Invalid card");
                    break;
            }

            //**Second version**

            //Console.Write("Enter your card if it is \"J\",\"Q\",\"K\" or \"A\" or if it isn't press ENTER: ");
            //string card = Console.ReadLine();
            //while (card != null)
            //{
            //    if (card == "J" || card == "Q" || card == "K" || card == "A")
            //    {

            //        Console.WriteLine("Valid Card");
            //        break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("No card");

            //    }


            //    Console.Write("Enter your card if it is between 2 and 10: ");
            //    int cards = int.Parse(Console.ReadLine());
            //    if (cards >= 2 && cards <= 10)
            //    {

            //        Console.WriteLine("Valid Card");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No card");
            //    }
            //    break;


            //}

        }



    }
}
