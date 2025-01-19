using System;
using System.Text.RegularExpressions;

namespace Splitting_Strings
{
    internal class App5
    {
        /*
        Splitting the String by a Separator
        */
        public static void Main(string[] args)
        {

            string sentence = "Hello, world! Welcome to C# programming.";
            char [] separator = {' ', ',', '.', '!'}; // Space character
            string[] words = sentence.Split(separator); // returned array of words.
            foreach (string word in words)
            {
                if (word == "") continue;//* if the word is empty string, skip it.
                Console.WriteLine(word);
            }
            /*Replacing a Substring*/
            //*! The syntax of Replace is : string.Replace(oldValue, newValue);
            string originalText = "I love ice cream."; // original text
            string newText = originalText.Replace("ice", "chocolate");// replacing "ice" with "chocolate"
            Console.WriteLine(newText);
            /*Regular Expressions*/
            /*
            !The syntax of Regular Expression is : Regex.Replace(text, pattern, replacement);
            !The syntax of Regular Expression is : Regex.Replace(text, pattern, replacement, count);
            !The syntax of Regular Expression is : Regex.Replace(text, pattern, replacement, options);
            */
            Console.Write("Please, enter a phone number : ");
            string phoneNumber = Console.ReadLine();
            string result = Regex.Replace(phoneNumber, @"(\d{3})(\d{3})(\d{5})", "$1 *** *** **");
            /*
                note : (\d{3}) means 3 digits of a number.
                note : (\d{3}) means 3 digits of a number.
                note : (\d{5}) means 5 digits of a number.
                note : $1 means the first group.
                note : * means repeat the previous group.
                note : @ means the end of the pattern.
            */ 
            Console.WriteLine(result);

            /*Removing Unnecessary Characters*/
            //*!The syntax of Trim is : string.Trim();
            string text = " *-$$$\t Hello, world! Welcome to C# programming.";
            char [] separators = {' ', '*', '-', '$', '\t'};
            string newText2 = text.Trim(separators);//* removing unnecessary characters
            Console.WriteLine(newText2);
        }
    }
}