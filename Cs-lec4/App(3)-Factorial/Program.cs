using System;

namespace Factorial
{
    /*
        formula : factorial(num) = num * (num-1) * (num-2) * (num-3).....* 1
        note : Factorial(0) = 1 , Factorial(1)=1;
        note : when (num is a positive number) ---> Factorail(num) = Factorial(num-1) * num;
        Note if the number is negative, it does not have a factorial
    */
    internal class App3
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
        static int CalculateUsingRecursion(int num)
        {
            if (num <= 1)
                return 1;
            else
                return CalculateUsingRecursion(num-1) * num;
        }
        static int CalculateUsingIteration(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i; 
            }
            return fact;
        }
        static void Main()
        {
            Console.WriteLine("formula : factorial(n) = n * (n-1) * (n-2) * (n-3).....* 1");
            Console.WriteLine("--------------------------------------------------------------------");
            int num = ReadNumber("Please, enter a positive number (n) : ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine($"Factorial({num}) using recursion = {CalculateUsingRecursion(num)}");
            Console.WriteLine($"Factorial({num}) using iteration = {CalculateUsingIteration(num)}");
        }
    }
}