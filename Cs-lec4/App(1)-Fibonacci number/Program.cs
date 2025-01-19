using System;

namespace FibonacciNumbers
{
    /*
    note : fib(1) = 1 , fib(0) = 0;
    note : when (n >= 2) ---> fib(n) = fib(n-1) + fib(n-2);
    the fibonacci sequences : 0 , 1 , 1 , 2 , 3 , 5 , 8 , 13 , 21 ,and so on;
    */
    internal class App1
    {
        static int ReadNumber(string Message)
        {
            int num = 0;
            do
            {
                Console.Write(Message);
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            return num;
        }
        //*Recursion : is when a function calls itself within its code, thus repeatedly executing the instructions present inside it.
        static int CalculateUsingRecursion(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else if (num == 0)
            {
                return 0;
            }
            else
            {
                return CalculateUsingRecursion(num - 1) + CalculateUsingRecursion(num - 2);
            }
        }
        //*Iteration is when a loop repeatedly executes the set of instructions like “for” loops and “while” loops.
        public static int CalculateUsingIteration(int num)
        {
            int a = 0, b = 1, temp;

            for (int i = 0; i < num; i++)
            {
                temp = a;
                a = b;
                b += temp;
            }
            return a;
        }
        static void Main()
        {
            int num = ReadNumber("Please, Enter the Positive Number : ");
            Console.WriteLine($"Fibonacci by recursion ({num}) : {CalculateUsingRecursion(num)}");
            Console.WriteLine($"Fibonacci by iteration ({num}) : {CalculateUsingIteration(num)}");
        }
    }
}