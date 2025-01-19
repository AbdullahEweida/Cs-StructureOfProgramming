using System;

namespace Power
{
    /*
        -Power of number ( x^n ): 
        note : x^0 = 1 ; x^1 = x;
        note when (n >= 2) --> x^n = x^(n-1) * x;
        note if (n < 0) --> x^n = 1 / (x^(n-1) * x); 
    */
    internal class App2
    {
        static int ReadNumber(string Message)
        {
            Console.Write(Message);
            return Convert.ToInt32(Console.ReadLine());;
        }
        static double CalculateUsingRecursion(int baseNumber ,int exponent)
        {
            if(exponent == 0)
                return 1;
            else if (exponent < 0)
                return 1 / CalculateUsingRecursion(baseNumber,-1*exponent);
            else
                return baseNumber * CalculateUsingRecursion(baseNumber,exponent-1);
        }
        static double CalculateUsingIteration(int baseNumber, int exponent)
        {
            double result = 1;
            int absExponent = Math.Abs(exponent);

            for (int i = 0; i < absExponent; i++)
            {
                result *= baseNumber;
            }

            return exponent >= 0 ? result : 1.0 / result;
        }
        static void Main()
        {
            Console.WriteLine("formula : x^n ");
            int baseNumber = ReadNumber("Please, enter base number (x) : ");
            int exponent = ReadNumber("Please, enter exponent  (n) : ");
            Console.WriteLine($"{baseNumber} ^ {exponent} using Recursion : {CalculateUsingRecursion(baseNumber,exponent)}");
            Console.WriteLine($"{baseNumber} ^ {exponent} using Iteration : {CalculateUsingIteration(baseNumber,exponent)}");                
            Console.WriteLine($"{baseNumber} ^ {exponent} using Math.Pow  : {Math.Pow(baseNumber,exponent)}");
        }
    }
}