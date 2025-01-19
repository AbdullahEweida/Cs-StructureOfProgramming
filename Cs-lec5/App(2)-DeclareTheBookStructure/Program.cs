using System;
using System.Numerics;

namespace TheBookStructure
{
    struct stBook
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
        public decimal price;
    }

    internal class App2
    {
        static void ReadBooks(stBook [] book,ref decimal totalPrice)
        {
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine($"-----------------book{i+1}-----------------");
                Console.Write("Please, enter the book title : ");
                book[i].title = Console.ReadLine();
                Console.Write("Please, enter the book author : ");
                book[i].author = Console.ReadLine();
                Console.Write("Please, enter the book subject : ");
                book[i].subject = Console.ReadLine();
                Console.Write("Please, enter the book-id : ");
                book[i].book_id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please, enter the book price : ");
                book[i].price = Convert.ToDecimal(Console.ReadLine());
                totalPrice += book[i].price;
            }
        }
        static void PrintBooks(stBook [] book,decimal totalPrice)
        {
            for (int i = 0; i < book.Length; i++)
            {
                Console.WriteLine($"--------------{book[i].title}--------------");
                Console.WriteLine($"The book author : {book[i].author}");
                Console.WriteLine($"The book subject :{book[i].subject}");
                Console.WriteLine($"The book-id : {book[i].book_id}");
                Console.WriteLine($"The book price : {book[i].price}");
            }
            Console.WriteLine("-----------------Total-----------------");
            Console.WriteLine($"Total books : {book.Length}");
            Console.WriteLine($"Total price : {totalPrice}");
        }
        static void Main()
        {
            Console.Write("Please, enter the book numbers : ");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());
            stBook [] books = new stBook [numberOfBooks];
            decimal totalPrice = 0;
            ReadBooks(books,ref totalPrice);
            PrintBooks(books,totalPrice);
        }
    }
}