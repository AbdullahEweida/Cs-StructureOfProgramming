using System;
using System.Data;
using System.Globalization;
namespace ParametersAndArguments
{
    static class App2
    {
        /*Method to read number*/
        static decimal ReadNum(string message)
        {
            Console.Write(message);
            return Convert.ToDecimal(Console.ReadLine());
        }
        /*Method to give maximum number between two number*/
        //*! Syntax : modifer <type-of-method> methodName (<type-of-parameter> parameters)
        static decimal CalcMaxNum(decimal num1,decimal num2)
        {
            return (num1 >= num2) ? num1 : num2; /*short hand if statement*/ 
        }
        static void Main()
        {
            decimal num1 = ReadNum("Please, enter the first number  : ");
            decimal num2 = ReadNum("Please, enter the second number : ");
            //*! Syntax : methodName(Argument);
            Console.WriteLine($"The maximum number : {CalcMaxNum(num1 , num2)}");
        }
    }
}
