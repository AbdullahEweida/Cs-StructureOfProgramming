using System;

namespace ParamsArray
{
    static class App1
    {
        /*Method to read number*/
        static decimal ReadNum(string message)
        {
            Console.Write(message);
            return Convert.ToDecimal(Console.ReadLine());
        }
        /*Method to give sum of numbers*/
        //*! Params Array: When designing methods that need to handle a flexible number of arguments.
        //*! Normal Array: When dealing with static or predefined collections of data.
        static decimal Sum(params decimal [] numbers)
        {
            decimal sum = 0;
            foreach (decimal number in numbers)
            {
                sum += number; 
            }
            return sum;
        }
        static void Main()
        {
            decimal num  = ReadNum("Please, enter the number1 : ");
            decimal num1 = ReadNum("Please, enter the number2 : ");
            decimal num2 = ReadNum("Please, enter the number3 : ");
            Console.WriteLine($"{num} + {num1} + {num2} = {Sum(num,num1,num2)}");
            Console.WriteLine($"{num} + {num1}  = {Sum(num,num1)}");
            Console.WriteLine($"{num} + {num2} = {Sum(num,num2)}");
            Console.WriteLine($"{num1} + {num2} = {Sum(num1,num2)}");
        }
    }
}