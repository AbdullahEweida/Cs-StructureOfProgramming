using System;
namespace Program;
static class Program
{
    static void Main()
    {
        Console.Write("Please enter your first number : ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Please enter your second number : ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        string Result = (num2==0) ? "divide by zero error encountered" : 
        $"{num1} / {num2} = {Math.Round(num1 / num2)}";
        Console.WriteLine(Result);
    }
}