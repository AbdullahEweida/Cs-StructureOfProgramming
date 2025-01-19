using System;
using System.IO;

namespace Assignment_2__Transpose_of_a_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/Assignment(2)-Transpose of a Matrix/Original Matrix.txt";//** the path of the file.
            StreamReader reader = new StreamReader (fileName);//** to read the file and to store it in a variable.
            string [] lines = File.ReadAllLines("/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/Assignment(2)-Transpose of a Matrix/Original Matrix.txt");//** to read all the lines in the file and store it in an array.
            int rows = lines.Length;//** to get the number of rows in the file.
            int columns = (lines[0].Split([' ', '\t'])).Length;//** to get the number of columns in the file.
            int[,] matrix = new int[rows, columns]; //** to create a 2D array to store the matrix.
            for (int i = 0; i < rows; i++)//** to read line by line.
            {
                string [] arrCol = new string [columns];
                arrCol = lines[i].Split([' ','\t']);//** to split the line into an array of strings.
                for (int j = 0; j < columns; j++)//** to read column by column.
                {
                    if (arrCol[j] == "") continue;
                    matrix[i, j] = Convert.ToInt32(arrCol[j]);//** to parse the string into an integer and to store it in the 2D array.
                }
            }
            reader.Close();//** to close the file after reading it.
            StreamWriter writer = new StreamWriter("/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/Assignment(2)-Transpose of a Matrix/Transpose of a Matrix.txt");//** to write the file and extract it in a variable.
            for (int i = 0; i < columns; i++)//** to read column by column.
            {
                for (int j = 0; j < rows; j++)//** to read line by line.
                {
                    writer.Write(matrix[j, i] + " ");//** to write the matrix in the file.
                }
                writer.WriteLine();//** to go to the next line.
            } 
            writer.Close();//** to close the file after writing it.
            Console.WriteLine("Done, the transpose has been written");//** to show that we have successfully written the file.
        }
    }
}