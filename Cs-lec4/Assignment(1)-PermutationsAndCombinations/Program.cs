using System;

namespace PermutationsAndCombinations
{
    internal class Assignment1
    {
        static int ReadNum(string Message)
        {
            int num = 0;
            do
            {
                Console.Write(Message);
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            return num;
        }

        static decimal Factorial(int Num)
        {
            if (Num <= 1)
            {
                return 1;
            }
            else
            {
                return Num * Factorial(Num - 1);
            }
        }

        static void Main(string[] args)
        {
            decimal C;
            decimal P;
            Console.WriteLine("Formula: C(n, r) = (n!) / (r!*(n-r)!)");
            int n1 = ReadNum("Please, n = ");
            int r1 = ReadNum("Please, r = ");
            if (n1 < r1)

                Console.WriteLine("Combinations : are not possiable");
            else
            {
                C = (Factorial(n1)) / (Factorial(r1) * Factorial(n1 - r1));
                Console.WriteLine("C ({0},{1}) = {2}", n1, r1, C);
            }

            Console.WriteLine();

            Console.WriteLine("Formula: P(n, r) = (n!) / (n-r)!");
            int n2 = ReadNum("Please, n = ");
            int r2 = ReadNum("Please, r = ");
            if (n2 < r2)
                Console.WriteLine("Permutations : are not possiable");
            else
            {
                P = (Factorial(n2)) / (Factorial(n2 - r2));
                Console.WriteLine("P ({0},{1}) = {2}", n2, r2, P);
            }
        }
    }
}
