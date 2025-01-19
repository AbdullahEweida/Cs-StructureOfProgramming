using System;

namespace DrawTriangle
{
    /*
    This program draws a triangle pattern:

    Example for input 3:
    1
    1  2
    1  2  3
    1  2
    1
    */
    internal class assingment1
    {
        /*Method to read number*/
        static int ReadNum(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        /* Method to draw the triangle pattern */
        static void DrawTriangle(int col)
        {
            // Draw the top half of the triangle
            for (int i = 1; i <= col; i++)
            {
                // Loop to print numbers in the current row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "  "); // Print each number followed by two spaces
                }
                Console.WriteLine(); // Move to the next line after finishing the row
            }

            // Draw the bottom half of the triangle
            for (int i = col - 1; i >= 1; i--)
            {
                // Loop to print numbers in the current row
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + "  "); // Print each number followed by two spaces
                }
                Console.WriteLine(); // Move to the next line after finishing the row
            }
        }

        static void Main()
        {
            int col = ReadNum("Please, enter the number of col : ");
            DrawTriangle(col);
        }
    }
}