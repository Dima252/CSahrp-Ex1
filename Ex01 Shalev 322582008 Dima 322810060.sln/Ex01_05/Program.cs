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
            string input = "";
            bool inputIsValid = false, isInputNumber = false;

            Console.WriteLine("Please enter integer with 8 digit's");

            while (inputIsValid == false)
            {
                input = Console.ReadLine();
                isInputNumber = isNumber(input);
                if (input.Length == 8 && isInputNumber)
                {
                    inputIsValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, Please enter a valid number:");
                }
            }

            HowManyDigitsSmallerThanLeft(input);

            howManyNumbersMode3(input);

            differenceBetweenSmallestAndLargest(input);

            MostCommonDigit(input);
        }
        static void MostCommonDigit(string input)
        {
            int count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0;
            int count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;
            int maxCount = 0;
            char mostCommon = '0';

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0': count0++; break;
                    case '1': count1++; break;
                    case '2': count2++; break;
                    case '3': count3++; break;
                    case '4': count4++; break;
                    case '5': count5++; break;
                    case '6': count6++; break;
                    case '7': count7++; break;
                    case '8': count8++; break;
                    case '9': count9++; break;
                }
            }

            if (count1 > maxCount) { 
                maxCount = count1; mostCommon = '1'; 
            }
            if (count2 > maxCount) { 
                maxCount = count2; mostCommon = '2'; 
            }
            if (count3 > maxCount) { 
                maxCount = count3; mostCommon = '3'; 
            }
            if (count4 > maxCount) { 
                maxCount = count4; mostCommon = '4'; 
            }
            if (count5 > maxCount) { 
                maxCount = count5; mostCommon = '5'; 
            }
            if (count6 > maxCount) { 
                maxCount = count6; mostCommon = '6'; 
            }
            if (count7 > maxCount) { 
                maxCount = count7; mostCommon = '7'; 
            }
            if (count8 > maxCount) { 
                maxCount = count8; mostCommon = '8';
            }
            if (count9 > maxCount)
            {
                maxCount = count9; mostCommon = '9';
            }

            Console.WriteLine("The most common digit is {0}, and it appears {1} times.", mostCommon, maxCount);
        }
        //  Because of the requirment, very ugly function !!!
        static void howManyNumbersMode3(string input)
        {
            int numbersMod3 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i].ToString()) % 3 == 0)
                {
                    numbersMod3++;
                }
            }
            Console.WriteLine("There are {0} numbers that are divisible by 3", numbersMod3);
        }
        static void differenceBetweenSmallestAndLargest(string input)
        {
            int smallest = 9, largest = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i].ToString()) < smallest)
                {
                    smallest = int.Parse(input[i].ToString());
                }
                if (int.Parse(input[i].ToString()) > largest)
                {
                    largest = int.Parse(input[i].ToString());
                }
            }
            Console.WriteLine("The difference between the smallest and largest digit is: {0}", largest - smallest);
        }
        static void HowManyDigitsSmallerThanLeft(string input)
        {
            int digitsSmallerThanLeft = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (int.Parse(input[i].ToString()) < int.Parse(input[0].ToString()))
                {
                    digitsSmallerThanLeft++;
                }
            }
            Console.WriteLine("There are {0} numbers smaller than the left one", digitsSmallerThanLeft);
        }
        static bool isNumber(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
