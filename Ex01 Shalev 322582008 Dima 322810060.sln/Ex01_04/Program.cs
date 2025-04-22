using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_04
{
    class Program
    {
        static void Main()
        {
            string input = "";
            bool inputIsValid = false;

            Console.WriteLine("Please enter a string of 12 char's");

            while (inputIsValid == false)
            {
                input = Console.ReadLine();
                if (input.Length == 12)
                {
                    inputIsValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, Please enter a valid string:");
                }


            }

            isPalindrome(input, 0, input.Length);

            isNumber(input);

        }
        static void isPalindrome(string input, int leftIndex,int size)
        {
            bool stringIs2Chars = false;
            if (leftIndex + 1 == size - 1)
            {
                stringIs2Chars = true;
            }
            if (stringIs2Chars)
            {
                if (char.ToLower(input[leftIndex]) == char.ToLower(input[size - 1]))
                {
                    Console.WriteLine("The string is a palindrome");
                    return;
                }
                else
                {
                    Console.WriteLine("The string is not a palindrome");
                    return;
                }
            }
            else
            {
                if (char.ToLower(input[leftIndex]) == char.ToLower(input[size - 1]))
                {
                    isPalindrome(input, ++leftIndex, --size);
                }
                else
                {
                    Console.WriteLine("The string is not a palindrome");
                    return;
                }
            }
        }

        static void isNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    Console.WriteLine("The string is not a number");
                    return;
                }
            }

            Console.WriteLine("The string is a number");
        }
    }
}