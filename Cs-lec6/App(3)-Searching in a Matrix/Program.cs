using System;
 
namespace SearchingInAMatrix
{
    static class App3
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
        static bool ResearchingMethod(decimal [,] Matrix,decimal number)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i,j] == number)
                    {
                        return true;                        
                    }
                }
            }
            return false;
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
            Console.Write("Please, enter the number of a rows : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols : ");
            int col = Convert.ToInt32(Console.ReadLine());
            decimal [,] Matrix = new decimal [row,col];
            ReadMatrix(Matrix);
            Console.Write("Please, enter the number to searching : ");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("_Matrix");
            PrintMatrix(Matrix);
            Console.WriteLine($"The result of searching : {ResearchingMethod(Matrix,number)}");
        }
    }
}