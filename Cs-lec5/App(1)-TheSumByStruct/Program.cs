using System;

namespace TheSumByStruct
{
    /*
       //*! Syntax :  <modifiers> struct <struct_name> {Structure members};
    */
    struct stNumbers
    {
        public decimal num1;
        public decimal num2;
        public decimal sum;
    }
    internal class App1
    {
        static decimal ReadNum(string Message)
        {
            Console.Write(Message);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static void Main()
        {
            //*! Syntax : <struct_name> <OP>;
            stNumbers Numbers;
            Numbers.num1 = ReadNum("Please, enter a first  number : ");
            Numbers.num2 = ReadNum("Please, enter a second number : ");
            Numbers.sum  = Numbers.num1 + Numbers.num2;
            Console.WriteLine($"Sum : {Numbers.num1} + {Numbers.num2} = {Numbers.sum}");
        }
    }
}