using System;
using System.Diagnostics.Contracts;

namespace Strings_Concatenation
{
    class App2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("The full name by concatenation (+) : ");
            Console.WriteLine("Hello " + firstName + " " + lastName);
            Console.WriteLine("The full name by string interpolation : ");
            Console.WriteLine($"Hello {firstName} {lastName}");
            Console.WriteLine("The full name by string format : ");
            Console.WriteLine("Hello {0} {1}", firstName, lastName);
            Console.WriteLine("The full name by string join : ");
            Console.WriteLine(string.Join(" ", "Hello", firstName, lastName));
            Console.WriteLine("The full name by string concat : ");
            Console.WriteLine(string.Concat("Hello ", firstName, " ", lastName));
        }
    }
}