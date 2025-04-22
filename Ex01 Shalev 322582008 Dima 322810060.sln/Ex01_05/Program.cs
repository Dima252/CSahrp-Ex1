using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_05
{
    class Program
    {
        static void Main()
        {
            string input;
            bool inputIsValid = false;

            Console.WriteLine("Please enter integer with 8 digit's");

            while (inputIsValid == false)
            {
                input = Console.ReadLine();
                if (input.Length == 8)
                {
                    inputIsValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, Please enter a valid number:");
                }
            }



        }
    }
}
