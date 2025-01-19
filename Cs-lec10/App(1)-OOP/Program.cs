using System;
namespace App_1__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //*! the syntax to create a class : className objectName = new className();
            //*! to call a method : objectName.methodName();
            //*! to call a property : objectName.propertyName = value; 
            clsCar car1 = new clsCar();//** Object and Constructor
            Console.Write("Enter Name: ");
            car1.Name = Console.ReadLine();
            Console.Write("Enter Year: ");
            car1.Year =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Make: ");
            car1.Make = Console.ReadLine();
            Console.Write("Enter Model: ");
            car1.Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            car1.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Color: ");
            car1.Color = Console.ReadLine();
            Console.Write("Enter Mileage: ");
            car1.Mileage = Convert.ToInt32(Console.ReadLine());
            car1.CarInfo();
        }
    }
}