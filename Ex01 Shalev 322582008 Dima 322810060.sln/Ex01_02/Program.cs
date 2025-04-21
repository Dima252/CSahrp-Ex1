using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_02
{
    public class Program
    {
        static void Main()
        {
            // Initialize tree parameters
            int heightOfTree = 7;
            int numberOfAscencion = 1;
            char charOfAscencion = 'A';
            int currentHeight = 1;

            // Print the tree body using recursion
            PrintRecursiveTree(currentHeight, heightOfTree, ref numberOfAscencion, ref charOfAscencion);

            // Print the tree trunk (two lines)
            PrintTreeTrunk(heightOfTree, numberOfAscencion, ref charOfAscencion);
        }

        public static void PrintRecursiveTree(int currentHeight, int i_heightOfTree, ref int io_numberOfAscencion, ref char io_charOfAscencion)
        {
            if (currentHeight == i_heightOfTree - 1)
            {
                return; // Base case: stop recursion
            }

            Console.Write(io_charOfAscencion); // Print current letter
            io_charOfAscencion++;

            // Print leading spaces for alignment
            for (int j = 0; j < i_heightOfTree - currentHeight; j++)
            {
                Console.Write(" ");
            }

            // Print number pattern, wrapping from 9 to 1
            for (int k = 0; k < currentHeight * 2 - 1; k++)
            {
                Console.Write(io_numberOfAscencion);
                if (io_numberOfAscencion == 9)
                {
                    io_numberOfAscencion = 1;
                }
                else
                {
                    io_numberOfAscencion++;
                }
            }

            Console.WriteLine();
            currentHeight++;

            // Recursive call for the next level
            PrintRecursiveTree(currentHeight, i_heightOfTree, ref io_numberOfAscencion, ref io_charOfAscencion);
        }

        public static void PrintTreeTrunk(int heightOfTree, int i_numberOfAscencion, ref char i_charOfAscencion)
        {
            for (int l = 0; l < 2; l++)
            {
                Console.Write(i_charOfAscencion); // Print letter
                i_charOfAscencion++;

                // Print leading spaces before trunk
                for (int m = 0; m < heightOfTree - 2; m++)
                {
                    Console.Write(" ");
                }

                // Print trunk with number
                Console.Write("|" + i_numberOfAscencion + "|");
                Console.WriteLine();
            }
        }
    }
}
