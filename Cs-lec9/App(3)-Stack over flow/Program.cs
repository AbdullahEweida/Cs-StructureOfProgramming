using System;

namespace App_3__Stack_over_flow
{
    class Program
    {
        static int GetNumberFromUser(string prompt)
        {
            int number;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }
            return number;
        }
        static int Power(int baseNum, int exponent)
        {
            if (exponent == 1)
            {
                return baseNum;
            }
            return baseNum * Power(baseNum, exponent - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Example : X^n");
            int baseNum = GetNumberFromUser("Enter the base number (X): ");
            int exponent = GetNumberFromUser("Enter the exponent (n): ");
            try
            {
                Console.WriteLine($"The result is {Power(baseNum, exponent)}");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Error: Stack overflow");
            }
        }
    }
}