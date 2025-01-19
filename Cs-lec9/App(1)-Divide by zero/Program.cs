using System;

namespace App_1__Calculator
{
    //try : A try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks.
    //catch : A catch block is used to handle exceptions.
    //throw : A throw statement is used to throw an exception.
    //finally : A finally block is executed regardless of whether an exception is thrown or not.
    //An exception is an unexpected event that occurs during program execution.
    class Program
    {
        static int Sum(int num1, int num2) { return num1 + num2; }
        static int Sub(int num1, int num2) { return num1 - num2; }
        static int Mul(int num1, int num2) { return num1 * num2; }
        static int Div(int num1, int num2) { return num1 / num2; }

        static int GetNumberFromUser(string prompt)//* to convert string to int and throw exception if input is not int.
        {
            int number;
            while (true)//* infinite loop if input is not int
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                    break;//* if input is int, break the loop
                }
                catch (FormatException)//* if input is not int
                {
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            int num1 = GetNumberFromUser("Please enter the first number: ");
            int num2 = GetNumberFromUser("Please enter the second number: ");

            Console.WriteLine($"The sum of {num1} and {num2} is {Sum(num1, num2)}");
            Console.WriteLine($"The difference of {num1} and {num2} is {Sub(num1, num2)}");
            Console.WriteLine($"The product of {num1} and {num2} is {Mul(num1, num2)}");

            try
            {
                Console.WriteLine($"The division of {num1} and {num2} is {Div(num1, num2)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero");
            }
            //note: to handle multiple exceptions
            //try
            //{
            //    Console.WriteLine($"The division of {num1} and {num2} is {Div(num1, num2)}");
            //}
            //catch (Exception ex) //*? to handle all exceptions
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
        }
    }
}