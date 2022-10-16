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
        Write("Enter month >> ");
        month = Convert.ToInt32(ReadLine());
        Write("Enter number of interior murals scheduled >> ");
        numInterior = Convert.ToInt32(ReadLine());
        Write("Enter number of exterior murals scheduled >> ");
        numExterior = Convert.ToInt32(ReadLine());
        if (new[] { 12, 1, 2 }.Contains(month)) // checks if month is in the array which includes 12, 1, 2
        {
            numExterior = 0;
        }
        if (new[] { 4, 5, 9, 10 }.Contains(month)) // checks if month is in the array which includes 4, 5, 9, 10
        {
            EXTERIOR_PRICE = 699;
        }
        if (new[] { 7, 8 }.Contains(month)) // checks if month is in the array which includes 7 and 8
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
