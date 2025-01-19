using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace TranversalMatrix
{
    internal class App1
    {
        static void ReadMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"Please, enter the element({i},{j}) : ");
                    Matrix[i,j] = Convert.ToDecimal(Console.ReadLine());
                }
            }
        }
        static void TranversalMatrix(decimal [,] Matrix)
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
            Console.Write("Please, enter the number of a rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            decimal [,] Matrix = new decimal [row,col];
            ReadMatrix(Matrix);
            Console.WriteLine("\tMatrix\t");
            TranversalMatrix(Matrix);
        }
    }
}