using System;
using System.IO; //** using to connect to the file system.

namespace App_1__Read_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"the text file.txt";//** this Relative path of the file.
            StreamReader reader = new StreamReader (fileName);//** to read the file and to store it in a variable.
            using (reader)//** to close the file after reading it. 
            {
                string line = reader.ReadLine();//** to read line by line.
                while (line != null)//** if the line is not null and to read line by line.
                {
                    Console.WriteLine(line);//** to print the line.
                    line = reader.ReadLine();//** to read another line and check if it is not null.
                }
            }
            Console.WriteLine("The end of the file (this message is not in the file)");//** to show that we have successfully read the file.
        }
    }
}
