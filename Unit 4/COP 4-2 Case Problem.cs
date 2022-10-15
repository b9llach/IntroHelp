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
        month = Convert.ToInt32(ReadLine()); // converts std input into an int, sets month to it
        Write("Enter number of interior murals scheduled >> "); // prints to screen
        numInterior = Convert.ToInt32(ReadLine()); // converts std input into an int, sets numInterior to it
        Write("Enter number of exterior murals scheduled >> "); // prints to screen
        numExterior = Convert.ToInt32(ReadLine()); // converts std input into an int, sets numExterior to it
        // new[] { 12, 1, 2 } creates a new array which contains the integer values 12, 1, and 2
        // .Contains(month) is a method we can call on an array to see if month is in that array
        if (new[] { 12, 1, 2 }.Contains(month)) // checks if month is in the array which includes 12, 1, 2
        {
            numExterior = 0; // sets numExterior to 0 bc during these months, we do not want any exterior
        }
        if (new[] { 4, 5, 9, 10 }.Contains(month)) // checks if month is in the array which includes 4, 5, 9, 10
        {
            EXTERIOR_PRICE = 699; // sets price to 699 if the month is 4, 5, 9, or 10
        }
        if (new[] { 7, 8 }.Contains(month)) // checks if month is in the array which includes 7 and 8
        {
            INTERIOR_PRICE = 450; // sets price to 450 if the month is 7 or 8
        }
        revenueInterior = numInterior * INTERIOR_PRICE; // calculates interior cost
        revenueExterior = numExterior * EXTERIOR_PRICE; // calculates exterior cost
        total = revenueInterior + revenueExterior; // just adds revInterior and revExterior, total is then set to its
        isInteriorGreater = numInterior > numExterior; // since isInteriorGreater is a bool, we can perform comparisons and set the value to it
        // so if numInterior > numExterior, isInteriorGreater would be set to true, else it would be false
        WriteLine($"{numInterior} interior murals are scheduled for a total of {revenueInterior.ToString("C")}"); // prints to screen
        WriteLine($"{numExterior} exterior murals are scheduled for a total of {revenueExterior.ToString("C")}"); // prints to screen
        WriteLine($"Total revenue expected is {total.ToString("C")}"); // prints to screen
        WriteLine($"It is {isInteriorGreater} that there are more interior murals scheduled than exterior ones."); // prints to screen
    }
}
