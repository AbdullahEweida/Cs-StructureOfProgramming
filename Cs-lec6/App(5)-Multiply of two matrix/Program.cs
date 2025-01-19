using System;

namespace Multiply_of_two_matrix
{
    /*
        Matrix multiplication :
        
        |e(1,1)		e(1,2)		e(1,3)|	 *	|m(1,1)	  m(1,2)|
        |e(2,1)		e(2,2)		e(2,3)|     |m(2,1)	  m(2,2)|
        |e(3,1)		e(3,2)		e(3,3)|		|m(3,1)	  m(3,2)|
			         i*k					       k*j
			         3*3					  	   3*2

	        |e(1,1)*m(1,1)+e(1,2)*m(2,1)+e(1,3)*m(3,1)	e(1,1)*m(1,2)+e(1,2)*m(2,2)+e(1,3)*m(3,2)|
        =   |e(2,1)*m(1,1)+e(2,2)*m(2,1)+e(2,3)*m(3,1)	e(2,1)*m(1,2)+e(2,2)*m(2,2)+e(2,3)*m(3,2)|
	        |e(3,1)*m(1,1)+e(3,2)*m(2,1)+e(3,3)*m(3,1)	e(3,1)*m(1,2)+e(3,2)*m(2,2)+e(3,3)*m(3,2)|
		    									      i*j
                                                 	  3*2
    */
    class Program
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
        static decimal [,] Multiply(decimal [,] Matrix1,decimal [,] Matrix2)
        {         
            /*row of Matrix3 = row of Matrix1*/
            /*col of Matrix2 = col of Matrix3*/
            decimal [,] Matrix3 = new decimal [Matrix1.GetLength(0),Matrix2.GetLength(1)];
            for (int i = 0; i < Matrix1.GetLength(0); i++)/*i = row of Matrix1 = row of Matrix3*/
            {
                for (int j = 0; j < Matrix2.GetLength(1); j++)/*j = col of Matrix2 = col of Matrix3*/
                {
                    for (int k = 0; k < Matrix1.GetLength(1); k++)/*k = col of Matrix1 and row of Matrix2*/
                    {
                        Matrix3[i,j] += Matrix1[i,k] * Matrix2[k,j];
                    }
                }
            }
            return Matrix3;
        }
        static void PrintMatrix(decimal [,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i,j]}",10);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            /*Read num.Col and num.Rows*/
            Console.Write("Please, enter the number of a rows in the first matrix : ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols in the first matrix : ");
            int col = Convert.ToInt32(Console.ReadLine());
            decimal [,] Matrix1 = new decimal [row,col];
            Console.Write("Please, enter the number of a rows in the second matrix : ");
            int row2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the number of a cols in the second matrix : ");
            int col2 = Convert.ToInt32(Console.ReadLine());
            decimal [,] Matrix2 = new decimal [row2,col2];
            /*Check the number of a cols in the first matrix must be equal to the number of a rows in the second matrix*/
            if (col != row2)
            {
                Console.WriteLine("The number of a cols in the first matrix must be equal to the number of a rows in the second matrix");
                return;
            }
            /*Read Two Matrices*/
            Console.WriteLine("\tEnter Matrix (1)");
            ReadMatrix(Matrix1);
            Console.WriteLine("\tEnter Matrix (2)");
            ReadMatrix(Matrix2);
            /*Print two Matrices*/
            Console.WriteLine("\tThe Matrix(1)");
            PrintMatrix(Matrix1);
            Console.WriteLine("\tThe Matrix(2)");
            PrintMatrix(Matrix2);
            /*Print Multiply*/
            Console.WriteLine("\tThe Multiply of Two Matrices");
            PrintMatrix(Multiply(Matrix1,Matrix2));
        }
    }
}