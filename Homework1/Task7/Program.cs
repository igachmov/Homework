using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };


            Console.Write("Enter some text: ");
            string text1 = Console.ReadLine();
            Console.Write("Enter some more text: ");
            string text2 = Console.ReadLine();
            string[] words = text1.Split(delimiterChars);
            string[] words1 = text2.Split(delimiterChars);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words1.Length; j++)
                {
                    if (words[i].Equals(words1[j]))
                    {
                        Console.WriteLine("Words that are the same: "+ words[i]);
                    }
                    
                }
            }
        }
    }
}
