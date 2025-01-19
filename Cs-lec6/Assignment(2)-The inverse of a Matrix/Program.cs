using System;

namespace The_inverse_of_a_Matrix
{
    internal class Assignment2
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
        static decimal [,] Minors(decimal [,] Matrix,int row,int col)
        {
            decimal [,] Minor = new decimal [Matrix.GetLength(0)-1,Matrix.GetLength(1)-1];
            int i = 0;
            int j = 0;
            for (int i1 = 0; i1 < Matrix.GetLength(0); i1++)
            {
                if (i1 == row)
                    continue;
                for (int j1 = 0; j1 < Matrix.GetLength(1); j1++)
                {
                    if (j1 == col)
                        continue;
                    Minor[i,j] = Matrix[i1,j1];
                    j++;
                }
                j = 0;
                i++;
            }
            return Minor;
        }
        static decimal Determinant(decimal [,] Matrix)
        {
            decimal determinant = 0;
            if (Matrix.GetLength(0) == 1)
                return Matrix[0,0];
            else if (Matrix.GetLength(0) == 2)
                return Matrix[0,0] * Matrix[1,1] - Matrix[1,0] * Matrix[0,1];
            else
            {
                //   +       -       +
                // e(0,0)  e(0,1)  e(0,2)
                // e(1,0)  e(1,1)  e(1,2)
                // e(2,0)  e(2,1)  e(2,2)

                for (int col = 0 ; col < Matrix.GetLength(0); col++)
                {
                    determinant += Convert.ToDecimal(Math.Pow(-1,col)) *  Matrix[0,col] * Determinant(Minors(Matrix,0,col));
                }
            }
            return determinant;
        }
        static decimal [,] AdjMatrix(decimal [,] Matrix)
        {
            decimal [,] adjMatrix = new decimal [Matrix.GetLength(0),Matrix.GetLength(1)];
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(0); col++)
                {
                    adjMatrix[row,col] = Convert.ToDecimal(Math.Pow(-1,row+col)) * Determinant(Minors(Matrix,row,col));
                }
            }
            return adjMatrix;
        }
        static decimal [,] TransMatrix(decimal [,] Matrix)
        {
            decimal [,] Transpose = new decimal [Matrix.GetLength(0),Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Transpose[i,j]  = Matrix[j,i];
                }
            }
            return Transpose;
        }
        static decimal [,] InvertedMatrix(decimal [,] Transpose,decimal Determinant)
        {
            for (int i = 0; i < Transpose.GetLength(0); i++)
            {
                for (int j = 0; j < Transpose.GetLength(1); j++)
                {
                    Transpose[i,j] = (1/Determinant)*Transpose[i,j];
                }
            }
            return Transpose;
        }
        static void PrintMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Math.Round(Matrix[i,j],2)}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of a row : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            if (row != col)
            {
                Console.WriteLine("The matrix is not square and cannot be inverted");
                return;
            }
            decimal [,] Matrix = new decimal [row,col];
            Console.WriteLine("\tPlease, enter the elements of a matrix");
            ReadMatrix(Matrix);
            Console.WriteLine("\tThe Matrix");
            PrintMatrix(Matrix);
            Console.WriteLine("\tThe determinant");
            decimal det = Determinant(Matrix);
            Console.WriteLine($"The determinant of a matrix : {det}");
            Console.WriteLine("\tThe Adj.Matrix");
            decimal [,] adjMatrix = AdjMatrix(Matrix);
            PrintMatrix(adjMatrix);
            Console.WriteLine("\tThe Transpose of Adj.Matrix");
            decimal [,] transpose = TransMatrix(adjMatrix);
            PrintMatrix(transpose);
            Console.WriteLine("\tThe Inverted Matrix");
            PrintMatrix(InvertedMatrix(transpose,det));
        }
    }
}