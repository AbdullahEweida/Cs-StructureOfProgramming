using System;

namespace StringsOperations
{
    internal class App2
    {
        static bool OperatorComparingString()
        {
            Console.Write("str1 : ");
            string str1 = Console.ReadLine();
            Console.Write("str2 : ");
            string str2 = Console.ReadLine();
            return (str1 == str2);
        }
        /*
            !Syntax : Equals(str1,str2);
            -return true (Both strings are equal in value) or false (Strings are not equal in value);
        */
        static bool EMethodComparingString()
        {
            Console.Write("str1 : ");
            string str1 = Console.ReadLine();
            Console.Write("str2 : ");
            string str2 = Console.ReadLine();
            return Equals(str1, str2);
        }
        /*
            ! Syntax : str1.CompareTo(str2);
            NOTE: -if return value
            1-(less than 0)-->The first string precedes the second string in the sort order.
            2-(Equal 0)-->Both strings are equal in value.
            3-(greater than 0)-->The first string follows the second string in the sort order.
        */
        static int CMethodComparingString()
        {
            Console.Write("str1 : ");
            string str1 = Console.ReadLine();
            Console.Write("str2 : ");
            string str2 = Console.ReadLine();
            return str1.CompareTo(str2);
        }
        static bool EIgnoreMethodComparingString()
        {
            Console.Write("str1 : ");
            string str1 = Console.ReadLine();
            Console.Write("str2 : ");
            string str2 = Console.ReadLine();
            return str1.Equals(str2,StringComparison.CurrentCultureIgnoreCase);
        }
        /*  
            To ignore the difference between small and capital letters in
            string comparison we can use the method Equals(…) with
            the parameter "StringComparison.CurrentCultureIgnoreCase".
            or use can the method String.Compare(string strA, string strB, boolignoreCase).
            !Note : str1.compareTo(str2) : not uses to ignore small or capital.
        */
        static int MethodComparingString()
        {
            Console.Write("str1 : ");
            string str1 = Console.ReadLine();
            Console.Write("str2 : ");
            string str2 = Console.ReadLine();
            Console.Write("Do you want to ignore capital or small letters(yes or no)? ");
            string ch = Console.ReadLine();
            if (ch == "yes" || ch == "y" || ch == "Yes" || ch == "Y")
            {
                return String.Compare(str1,str2,true);
            }
            return String.Compare(str1,str2,false);
        }
        static void Main()
        {
            /*1-Comparing Strings in Alphabetical Order*/
            Console.WriteLine("Choosing Comparing Strings in Alphabetical Order");
            Console.WriteLine("1-by operator \"==\" ");
            Console.WriteLine("2-by method \"Equals(str1,str2)\" ");
            Console.WriteLine("3-by method \"str1.compareTo(str2)\" ");
            Console.WriteLine("4-by method \"str1.Equals(str2,StringComparison.CurrentCultureIgnoreCase)\" ");
            Console.WriteLine("5-by method \"String.Compare(str1,str2,ignoreCase)\" ");
            Console.Write("Enter your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Comparing Strings in Alphabetical Order(with operator \"==\" )");
                Console.WriteLine(OperatorComparingString());
            }
            else if (choice == 2)
            {
                Console.WriteLine("Comparing Strings in Alphabetical Order(with method \"Equals(str1,str2)\" )");
                Console.WriteLine(EMethodComparingString());
            }
            else if (choice == 3)
            {
                Console.WriteLine("Comparing Strings in Alphabetical Order(with method \"str1.compareTo(str2)\" )");
                Console.WriteLine(CMethodComparingString());
            }
            else if (choice == 4)
            {
                Console.WriteLine("Comparing Strings in Alphabetical Order(with method \" str1.Equals(str2,StringComparison.CurrentCultureIgnoreCase) \" ");
                Console.WriteLine(EIgnoreMethodComparingString());
            }
            else if (choice == 5)
            {
                Console.WriteLine("Comparing Strings in Alphabetical Order(with method \" String.Compare(str1,str2,ignoreCase) \" ");
                Console.WriteLine(MethodComparingString());
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }

    }
}