using System;

namespace TheThreeMethods
{
    /*
        Write a program that contains three methods. The first
        method is to find the smallest number in a matrix, 
        the second method is to find the largest numbers in a matrix, and
        the third method is to calculate the sum of the squares of the elements of the diagonal. 
        In the main method read a matrix and print the result of each method after applying it to the read matrix.
    */
    class Program
    {
        /*Read Matrix*/
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
        /*The first method : Smallest Number*/
        static decimal SmallestNumber(decimal [,] Matrix)
        {
            decimal smallest = Matrix[0,0];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i,j] < smallest)
                    {
                        smallest = Matrix[i,j];
                    }
                }
            }
            return smallest;
        }
        /*The second method : Largest Number*/
        static decimal LargestNumber(decimal [,] Matrix)
        {
            decimal largest = Matrix[0,0];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i,j] > largest)
                    {
                        largest = Matrix[i,j];
                    }
                }
            }
            return largest;
        }
        /*The third method : Sum of the squares of the elements of the diagonal*/
        static decimal SumSquaresOfDiagonal(decimal [,] Matrix)
        {
            decimal sum = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += Matrix[i,j] * Matrix[i,j];
                    }
                }
            }
            return sum;
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
        static void Main(string[] args)
        {
            Console.Write("Please, enter the number of a rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            if (row != col)
            {
                Console.WriteLine("The matrix is not square");
                return;
            }
            decimal [,] Matrix = new decimal [row,col];
            Console.WriteLine("\tPlease, enter the elements of a matrix");
            ReadMatrix(Matrix);
            Console.WriteLine("\tThe Matrix\t");
            PrintMatrix(Matrix);
            Console.WriteLine("\tResult\t");
            Console.WriteLine($"The smallest number in a matrix : {SmallestNumber(Matrix)}");
            Console.WriteLine($"The largest number in a matrix : {LargestNumber(Matrix)}");
            Console.WriteLine($"The sum of the squares of the elements of the diagonal : {SumSquaresOfDiagonal(Matrix)}");
        }
    }
}