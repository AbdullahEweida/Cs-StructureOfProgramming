using System;
using System.IO;

namespace Assignment_1__Arange_the_list_of_names
{
    class Program
    {
        /*
            Write a program that reads a list of names from a text file, arranges them in alphabetical
            order and writes them to another file. The lines are written one per row.
        */
        static void Main(string[] args)
        {
            
            //** 1st way

            /*string[] names = File.ReadAllLines("/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/Assignment(1)-Arange the list of names/Original names.txt");
            Array.Sort(names);
            File.WriteAllLines("/mnt/data2/Cs-StructureOfProgramming/Cs-lec8/Assignment(1)-Arange the list of names/Sorted names.txt", names);*/

            //** 2nd way

            StreamReader reader = new StreamReader(@"Original names.txt");
            StreamWriter writer = new StreamWriter(@"Sorted names.txt");
            string [] Names = File.ReadAllLines(@"Original names.txt");//** to read all a names in the file and store it in an array.
            Array.Sort(Names);//** to sort the names in alphabetical order.
            foreach (string name in Names)//** to write the names in the file.
            {
                if (name == null) continue; 
                writer.WriteLine(name);
            }
            reader.Close();//** to close the file after reading it.
            writer.Close();//** to close the file after writing it.
            Console.WriteLine("Done, the names have been written and sorted");//** to show that we have successfully written the file.
        }
    }
}