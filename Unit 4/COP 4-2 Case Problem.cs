using System;
using System.Linq;
using static System.Console;
class MarshallsRevenue
{
    static void Main()
    {
        int INTERIOR_PRICE = 500; // set interior price
        int EXTERIOR_PRICE = 750; // set exterior price
        int numInterior, numExterior, revenueInterior, revenueExterior, total, month;
        bool isInteriorGreater;
        Write("Enter month >> "); // prints to screen
        month = Convert.ToInt32(ReadLine()); // converts user input to int
        Write("Enter number of interior murals scheduled >> "); // prints to screen
        numInterior = Convert.ToInt32(ReadLine()); // converts user input to int
        Write("Enter number of exterior murals scheduled >> "); // prints to screen
        numExterior = Convert.ToInt32(ReadLine()); // converts user input to int
        if (month == 12 || month == 1 || month == 2) // checks if month is 12, 1, 2
        {
            numExterior = 0;
        }
        if (month == 4 || month == 5 || month == 9 || month == 10) // checks if month is 4, 5, 9, 10
        {
            EXTERIOR_PRICE = 699;
        }
        if (month == 7 || month == 8) // checks if month is 7 or 8
        {
            INTERIOR_PRICE = 450;
        }
        revenueInterior = numInterior * INTERIOR_PRICE;
        revenueExterior = numExterior * EXTERIOR_PRICE;
        total = revenueInterior + revenueExterior;
        isInteriorGreater = numInterior > numExterior;
        WriteLine($"{numInterior} interior murals are scheduled for a total of {revenueInterior.ToString("C")}");
        WriteLine($"{numExterior} exterior murals are scheduled for a total of {revenueExterior.ToString("C")}");
        WriteLine($"Total revenue expected is {total.ToString("C")}");
        WriteLine($"It is {isInteriorGreater} that there are more interior murals scheduled than exterior ones.");
    }
}
