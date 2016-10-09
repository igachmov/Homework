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
            //Напишете програма, която кара потребителя да въвежда числа и ги сумира. 
            //Края на програмата настъпва, единствено когато потребителя въведе числото 0.


            string number = null;
            int b = 0;
            do 
            {

                Console.Write("Enter a number to add(to finish adding type 0): ");
                int a = int.Parse(Console.ReadLine());
                
                b = b +a;
                Console.WriteLine("The sum is: "+b);

                number = a.ToString();
                
            } while (number != "0") ;
                


        }
    }
}
