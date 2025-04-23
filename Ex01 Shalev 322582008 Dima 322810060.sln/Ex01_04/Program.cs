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
            bool isNum, consistOfChars;

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

            isNum = isNumber(input);

            if (isNum)
            {
                isMod3(input);
            }
            else
            {
                consistOfChars = consistOfCharacters(input);

                if (consistOfChars)
                {
                    HowManyUpperChars(input);
                    increasingOrderOfMagnitude(input);
                }
            }
        }
        static void increasingOrderOfMagnitude(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (char.ToLower(input[i]) > char.ToLower(input[i + 1]))
                {
                    Console.WriteLine("The string is not in increasing order of magnitude");
                    return;
                }
            }
            Console.WriteLine("The string is in increasing order of magnitude");
        }
        static void HowManyUpperChars(string input)
        {
            int upperChars = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    upperChars++;
                }
            }
            Console.WriteLine("The string has {0} upper Characters", upperChars);
        }

        static bool consistOfCharacters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    Console.WriteLine("The string not fully consists of characters");
                    return false;
                }
            }

            Console.WriteLine("The string fully consists of characters");
            return true;
        }
        static void isMod3(string input)
        {
            long number = long.Parse(input);
            if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else
            {
                Console.WriteLine("The number is not divisible by 3");
            }
        }
        static void isPalindrome(string input, int leftIndex, int size)
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
        static bool isNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    Console.WriteLine("The string is not a number");
                    return false;
                }
            }

            Console.WriteLine("The string is a number");
            return true;
        }
    }
}