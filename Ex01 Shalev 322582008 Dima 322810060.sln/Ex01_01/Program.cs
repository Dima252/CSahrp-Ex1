using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryToDecimalNumbers = new int[4];
            // Declare the array to hold the decimal numbers

            int[][] binaryToIntNumbers = new int[4][];

            Console.WriteLine("Please enter 4 numbers with 7 digits each:");

            for (int inputCount = 0; inputCount < 4; inputCount++)
            {
                bool inputIsValid = false;
                string numberInput = string.Empty; // Declare and initialize numberInput here

                while (inputIsValid == false)
                {
                    numberInput = Console.ReadLine(); // Assign value to numberInput
                    inputIsValid = isValidInput(numberInput);
                    if (inputIsValid == false)
                    {
                        Console.WriteLine("Invalid input, Please enter a valid number:");
                    }
                }
                binaryToDecimalNumbers[inputCount] = binaryToDecimalConverter(numberInput);

                binaryToIntNumbers[inputCount] = arrayBreakdown(numberInput);

            }

            printDecimalNumbersInDescendingOrder(binaryToDecimalNumbers);

            printDecimalAverage(binaryToDecimalNumbers);

            numberWithLongestSeriesOfOne(binaryToIntNumbers);

            numberOfExchanges(binaryToIntNumbers);

            printNumberOfOnes(binaryToIntNumbers);
        }

        static int binaryToDecimalConverter(string binaryNumber)
        {
            int decimalNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[binaryNumber.Length - 1 - i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, i);
                }
            }
            return decimalNumber;
        }

        static bool isValidInput(string numberInput)
        {
            if (numberInput.Length != 7)
            {
                return false;
            }
            foreach (char c in numberInput)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        static int[] arrayBreakdown(string numberInput)
        {
            int[] binaryToIntNumbers = new int[7];
            for (int i = 0; i < numberInput.Length; i++)
            {
                binaryToIntNumbers[i] = Convert.ToInt32(numberInput[i].ToString());
            }
            return binaryToIntNumbers;
        }

        static void printDecimalNumbersInDescendingOrder(int[] binaryToDecimalNumbers)
        {
            Array.Sort(binaryToDecimalNumbers);
            Array.Reverse(binaryToDecimalNumbers);

            Console.WriteLine("These are the decimal numbers in descending order:");
            for (int i = 0; i < binaryToDecimalNumbers.Length; i++)
            {
                Console.WriteLine(binaryToDecimalNumbers[i]);
            }
        }

        static void printDecimalAverage(int[] binaryToDecimalNumbers)
        {
            double average = binaryToDecimalNumbers.Average();
            Console.WriteLine("The average of the decimal numbers is: " + average);
        }

        static void numberWithLongestSeriesOfOne(int[][] binaryToIntNumbers)
        {
            int indexWithLongestSeries = -1;
            int longestSeries = 0;

            for (int i = 0; i < binaryToIntNumbers.Length; i++)
            {
                int currentSeries = 0;
                int maxSeriesForThisNumber = 0;

                for (int j = 0; j < binaryToIntNumbers[i].Length; j++)
                {
                    if (binaryToIntNumbers[i][j] == 1)
                    {
                        currentSeries++;
                        maxSeriesForThisNumber = Math.Max(maxSeriesForThisNumber, currentSeries);
                    }
                    else
                    {
                        currentSeries = 0;
                    }
                }

                if (maxSeriesForThisNumber > longestSeries)
                {
                    longestSeries = maxSeriesForThisNumber;
                    indexWithLongestSeries = i;
                }
            }

            // Print the result
            Console.WriteLine("The longest series of 1's is: " + longestSeries +
                              " in number: " + string.Join("", binaryToIntNumbers[indexWithLongestSeries]));
        }

        static void numberOfExchanges(int[][] binaryToIntNumbers)
        {
            int numberOfExchanges = 0;
            
            for (int i = 0; i < binaryToIntNumbers.Length; i++)
            {
                for (int j = 0; j < binaryToIntNumbers[i].Length - 1; j++)
                {
                    if (binaryToIntNumbers[i][j] != binaryToIntNumbers[i][j + 1])
                    {
                        numberOfExchanges++;
                    }
                }
                Console.WriteLine("The number of exchanges in number " + ( i + 1 ) + " : " + numberOfExchanges);
                numberOfExchanges = 0; // Reset for the next number
            }
          

        }

        static void printNumberOfOnes(int[][] binaryToIntNumbers)
        {
            int count = 0;
            int totalCount = 0;
            int maxCount = 0;
            int maxIndex = 0;
            for (int i = 0; i < binaryToIntNumbers.Length; i++)
            { 
                for(int j = 0; j < binaryToIntNumbers[i].Length; j++)
                {
                    if(binaryToIntNumbers[i][j] == 1)
                    {
                        count++;
                        totalCount++;
                    }
                    
                }
                if(count > maxCount)
                {
                    maxCount = count;
                    maxIndex = i;
                }

                count = 0; // Reset for the next number
                
            }
            Console.WriteLine("The number with the most 1's is: " + string.Join("", binaryToIntNumbers[maxIndex]));
            Console.WriteLine("The number of 1's in total is : " + totalCount);
        }
    }
}
