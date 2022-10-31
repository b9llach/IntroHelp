// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must reenter the number
// The program displays the correct price
using System;
using static System.Console;
using System.Globalization;
class DebugFive2
{
    static void Main()
    {
        // const means that the value of the variable can never change, it is constant
        const string ITEM209 = "209"; // set variable of type string = "209"
        const string ITEM312 = "312"; // set variable of type string = "312"
        const string ITEM414 = "414"; // set variable of type string = "414"
        const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07; // set variables of type double equal to price
        double price; // create variable of type double
        string stockNum; // create variable of type string
        Write("Please enter the stock number of the item you want >> "); // prints to screen
        stockNum = ReadLine(); // sets stockNum equal to whatever the user entered
        while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414) // while stockNum is not one of our strings created above
        {
            WriteLine("Invalid stock number. Please enter again."); // prints to screen
            stockNum = ReadLine(); // sets stockNum equal to whatever the user entered
        }
        if (stockNum == ITEM209) // if stockNum is equal to whatever ITEM209 is equal to
        {
            price = PRICE209; // price is equal to the value of PRICE209
        }
        else if (stockNum == ITEM414) // if stockNum is equal to whatever ITEM414 is equal to
        {
            price = PRICE414; // price is equal to the value of PRICE414
        }
        else // if stockNum is anything else and is an item
        {
            price = PRICE312; // price is equal to the value of PRICE312
        }
        WriteLine($"The price for item # {stockNum} is {price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        // prints to screen the item number and the price of the item number
    }
}
