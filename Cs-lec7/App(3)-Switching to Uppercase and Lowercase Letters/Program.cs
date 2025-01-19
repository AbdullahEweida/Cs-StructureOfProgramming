using System;

namespace Switching_to_Uppercase_and_Lowercase_Letters
{
    class App3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word : ");
            string word = Console.ReadLine();
            Console.WriteLine("The word in uppercase : ");
            Console.WriteLine(word.ToUpper());
            Console.WriteLine("The word in lowercase : ");
            Console.WriteLine(word.ToLower());
            /*can used to ignore the difference between small and capital letters in string comparison*/
            Console.WriteLine("Please enter a word2 : ");
            string word2 = Console.ReadLine();
            Console.WriteLine("The Compared word in uppercase : ");
            Console.WriteLine( word.ToUpper().Equals(word2.ToUpper()));
            Console.WriteLine("The Compared word in lowercase : ");
            Console.WriteLine(word.ToLower().Equals(word2.ToLower()));  
        }
    }
}