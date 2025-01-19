using System;

namespace TransposeOfAMatrix
{
    class App4
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
        static decimal [,] Transpose(decimal [,] Matrix)
        {
            decimal [,] TransposeMatrix = new decimal [Matrix.GetLength(1),Matrix.GetLength(0)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    TransposeMatrix[j,i] = Matrix[i,j];
                }
            }
            return TransposeMatrix;
        }
        static void PrintMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of a rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            decimal [,] Matrix = new decimal [row,col];
            ReadMatrix(Matrix);
            Console.WriteLine("\tMatrix\t");
            PrintMatrix(Matrix);
            Console.WriteLine("\tTranspose\t"); 
            PrintMatrix(Transpose(Matrix));    
        }
    }
}