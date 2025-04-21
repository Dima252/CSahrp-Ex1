using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex01_02;

namespace Ex01_03
{
    class Program
    {
        static void Main()
        {
            bool inputIsValid = false;
            int heightOfTree = 0;

            Console.WriteLine("Please enter a number between 4 and 15:");

            // Keep asking until valid number is entered
            while (!inputIsValid)
            {
                string userInput = Console.ReadLine(); // Read input as string

                // Try parsing the input to an integer
                if (int.TryParse(userInput, out heightOfTree))
                {
                    inputIsValid = isValidInput(heightOfTree);

                    if (!inputIsValid)
                    {
                        Console.WriteLine("Number must be between 4 and 15. Try again:");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }

            // Initialize values for tree generation
            int numberOfAscencion = 1;
            char charOfAscencion = 'A';
            int currentHeight = 1;

            // Call tree methods from the other project
            Ex01_02.Program.PrintRecursiveTree(currentHeight, heightOfTree, ref numberOfAscencion, ref charOfAscencion);
            Ex01_02.Program.PrintTreeTrunk(heightOfTree, numberOfAscencion, ref charOfAscencion);
        }

        // Check if number is within valid range
        static bool isValidInput(int input)
        {
            return input >= 4 && input <= 15;
        }
    }
}
