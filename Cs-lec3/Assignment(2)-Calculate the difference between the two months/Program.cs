using System;
class Months
{
    static string GetMonthName(int month)
    {
        string monthName;
        switch (month)
        {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;

            case 12:
                monthName = "December";
                break;
            default:
                Console.WriteLine("Invalid month!");
                return null;
        }
        return monthName;
    }
static void SayPeriod(int startMonth, int endMonth)
{
    // Calculate the difference between the two months
    int period = endMonth - startMonth;
    
    // If the difference is negative, it means the second month is after the first month in the next year
    if (period < 0)
    {
        // Adjust the period by adding 12 to make it positive (moving into the next year)
        period = period + 12;
    }
    
    // Print the result with the period between the two months
    Console.WriteLine(
        "There is {0} months period from {1} to {2}.", period, 
        // Call the GetMonthName function to get the name of the first month
        GetMonthName(startMonth),
        // Call the GetMonthName function to get the name of the second month
        GetMonthName(endMonth)
    );
}

    static void Main()
    {
        Console.Write("First month (1-12): ");
        int firstMonth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second month (1-12): ");
        int secondMonth = Convert.ToInt32(Console.ReadLine());
        SayPeriod(firstMonth, secondMonth);
    }
}