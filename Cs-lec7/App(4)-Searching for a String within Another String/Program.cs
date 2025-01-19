using System;

namespace Searching_for_a_String_within_Another_String
{
    /*
        ~ The result of those methods is an integer.
        • If the result is not a negative value, then this is the position
        where the first character of the substring is found.
        • If the method returns value of -1, it means that the substring
        was not found.
        • Remember that in C# indexing into strings start from 0.
    */

    class App4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a statement : ");
            string statement = Console.ReadLine();
            Console.Write("Please enter a word (for search in the statement) : ");
            string word = Console.ReadLine();

            //*! The syntax of IndexOf is : statement.IndexOf(subString,startIndex);
            //*! The syntax of LastIndexOf is : statement.LastIndexOf(subString,startIndex);
            //*? note : startIndex is not specified, the default value is 0.

            int index = statement.IndexOf(word);
            if (index != -1)
            {
                Console.WriteLine($"The word is found in the statement in index : {index}");
            }
            else
            {
                Console.WriteLine("The word is not found in the statement.");
                return;//exit the program.
            }

            /*Finding All Occurrences of a Substring*/
            Console.WriteLine("Finding All Occurrences of a Substring");
            index = statement.IndexOf(word);
            while (index != -1)
            {
                Console.WriteLine($"The word is found in the statement in index : {index}");
                index = statement.IndexOf(word, index + 1);
            }
            
            /*Extracting a File Name and File Extension*/
            //*! The syntax of Substring is : string.Substring(startIndex, length);
            //*? note : the length is not specified, the default value is the rest of the string.
            //*? The method LastIndexOf returns the index of the last occurrence of a substring in a string.
            Console.WriteLine("Extracting a File Name and File Extension");
            Console.Write("Please enter a path of a file : ");
            string path = Console.ReadLine();
            int index2 = path.LastIndexOf('/');
            Console.WriteLine($"The index of a file name in a path is : {index2}");
            Console.WriteLine($"The full name of a file is : {path.Substring(index2 + 1)}");
        }
    }
}