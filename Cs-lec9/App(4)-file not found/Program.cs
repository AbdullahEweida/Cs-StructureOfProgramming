using System;
using System.IO;

namespace App_4__file_not_found
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/mnt/data2/Cs-StructureOfProgramming/Cs-lec9/App(4)-file not found/Program.txt";
            try
            {
                string text = File.ReadAllText(path);//** To read the all content of the file.
                Console.WriteLine(text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: File not found in the specified path.");
            }
        }   
    }
}