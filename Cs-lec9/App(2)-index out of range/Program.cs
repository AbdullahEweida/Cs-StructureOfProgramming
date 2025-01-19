using System;

namespace App_2__index_out_of_range
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int index = GetNumberFromUser("Enter the index: ");
            try
            {
                Console.WriteLine($"The value at index {index} is {arr[index]}");
            }
            catch (IndexOutOfRangeException)//** if index is out of range Print error.
            {
                Console.WriteLine("Error: Index out of range");
            }
        }
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
                catch (FormatException)//** if input is not int Print error message.
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }
            return number;
        }
    }
}