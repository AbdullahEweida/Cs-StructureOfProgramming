using System;
using System.IO; //** using to connect to the file system.

namespace App_2__Write_Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/App(2)-Write Stream/the file text .txt";//** the path of the file.
            StreamWriter writer = new StreamWriter (fileName);//** to write the file and extract it in a variable.
            using (writer)//** to close the file after writing it. 
            {
                writer.WriteLine("the text that will be written in the file.");//** to write the text in the file.
                writer.WriteLine("My name : Abdullah Badri Eweida.");
                writer.WriteLine("I study computer science in Math.");
                writer.WriteLine("This file is for testing the program.");
            }
            Console.WriteLine("Done, the file has been written");//** to show that we have successfully written the file.
        }
    }
}