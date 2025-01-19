namespace App_1__OOP;

public class clsCar
{
    public string Name;//* Data Members
    public int Year ;
    public string Make;
    public string Model;
    public double Price;
    public string Color;
    public int Mileage;
    public void CarInfo()//**Member Functions
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Year: " + Year);
        Console.WriteLine("Make: " + Make);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Mileage: " + Mileage);
    }
}
