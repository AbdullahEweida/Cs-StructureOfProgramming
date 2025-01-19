using System;
using System.Data;
using System.Globalization;
namespace SignOfNumber
{
    static class App1
    {
        /*Method to read number*/
        static decimal ReadNum(string message)
        {
            Console.Write(message);
            return Convert.ToDecimal(Console.ReadLine());
        }
        /*Method to Show whether a Number is Positive*/
        static string Sign(decimal num)
        {
            if (num > 0)
                return "The number is positive";
            else if (num < 0)
                return "The number is negative";
            else
                return "The number equal ZERO";
        }
        static void Main()
        {
            decimal num = ReadNum("Please, enter the number : ");
            Console.WriteLine(Sign(num));
        }
    }
}
