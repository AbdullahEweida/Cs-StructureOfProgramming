using System;
using System.Data;

namespace SumOfTwoMatrices
{
    internal class App2
    {
        static void ReadMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"Please, enter the element({i+1},{j+1}) : ");
                    Matrix[i,j] = Convert.ToDecimal(Console.ReadLine());
                }
            }
        }
        static decimal [,] SumOfTwoMatrices(decimal [,] Matrix1,decimal [,] Matrix2)
        {
            decimal [,] Sum = new decimal [Matrix1.GetLength(0),Matrix1.GetLength(1)];
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    Sum[i,j] = Matrix1[i,j] + Matrix2[i,j];
                }
            }
            return Sum;
        }
        static void PrintMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            /*Read num.Col and num.*/
            Console.Write("Please, enter the number of a rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            /*Read Two Matrices*/
            Console.WriteLine("\tEnter Matrix (1)");
            decimal [,] Matrix1 = new decimal [row,col];
            ReadMatrix(Matrix1);
            Console.WriteLine("\tEnter Matrix (2)");
            decimal [,] Matrix2 = new decimal [row,col];
            ReadMatrix(Matrix2);
            /*Print two Matrices*/
            Console.WriteLine("\tThe Matrix(1)");
            PrintMatrix(Matrix1);
            Console.WriteLine("\tThe Matrix(2)");
            PrintMatrix(Matrix2);
            /*Print Sum*/
            Console.WriteLine("\tThe Sum of Two Matrices\t");
            PrintMatrix(SumOfTwoMatrices(Matrix1,Matrix2));
        }
    }
}