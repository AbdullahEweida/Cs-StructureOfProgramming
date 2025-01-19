using System;

namespace FindTotalPrice
{
    internal class Price
    {
        static void Main()
        {
            Console.Write("Please, enter number of icecreams : ");
            int numOfIcecream = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter price of each Ice-cream : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please, enter a customer's name : ");
            string custName = Console.ReadLine();
            Console.WriteLine($"{custName}  ordered {numOfIcecream} ice creams for {price*numOfIcecream}");
        }
    }
}
